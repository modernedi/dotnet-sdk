using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using ModernEdi.Model;
using Xunit;

namespace ModernEdi.Tests;

public class ContractTests
{
    public static IEnumerable<object[]> Cases()
    {
        using var corpus = JsonDocument.Parse(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "fixtures/cases.json")));
        foreach (var row in corpus.RootElement.GetProperty("cases").EnumerateArray())
            yield return [row.GetProperty("id").GetString()!, row.GetProperty("schema").GetString()!,
                row.TryGetProperty("wireJson", out var wireJson) ? wireJson.GetString()! : row.GetProperty("value").GetRawText()];
    }

    [Theory, MemberData(nameof(Cases))]
    public void Published_examples_round_trip(string id, string schema, string json)
    {
        var type = typeof(ModernEdiClient).Assembly.GetType("ModernEdi.Model." + schema, throwOnError: true)!;
        var parsed = JsonSerializer.Deserialize(json, type, WireJson.Options);
        var actual = JsonSerializer.Serialize(parsed, type, WireJson.Options);
        Assert.True(JsonNode.DeepEquals(JsonNode.Parse(json), JsonNode.Parse(actual)), id + "\n" + actual);
    }

    [Fact]
    public async Task Every_operation_routes_and_authenticates_once()
    {
        using var contract = JsonDocument.Parse(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "fixtures/contract.json")));
        using var handler = new RecordingHandler(_ => new(HttpStatusCode.NoContent));
        using var http = new HttpClient(handler);
        using var client = new ModernEdiClient(apiKey: "synthetic", httpClient: http);
        var operations = typeof(ModernEdiClient).GetProperties().Where(p => p.PropertyType.Name.EndsWith("Api"))
            .SelectMany(property => property.PropertyType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
                .Select(method => (Target: property.GetValue(client), Method: method))).ToArray();
        foreach (var operation in contract.RootElement.GetProperty("operations").EnumerateArray())
        {
            var id = operation.GetProperty("operationId").GetString()!;
            var name = char.ToUpperInvariant(id[0]) + id[1..] + "Async";
            var call = Assert.Single(operations, o => o.Method.Name == name);
            var arguments = call.Method.GetParameters().Select(p => p.HasDefaultValue ? (p.ParameterType == typeof(CancellationToken) ? CancellationToken.None : p.DefaultValue) :
                p.ParameterType == typeof(string) ? (p.Name == "ifMatch" ? "\"fixture\"" : "fixture") : p.ParameterType == typeof(int) ? 7 :
                p.ParameterType == typeof(JsonElement) ? JsonSerializer.SerializeToElement(new { }) :
                p.ParameterType == typeof(RequestBody) ? RequestBody.Text("ST*850~", "application/edi-x12") : Activator.CreateInstance(p.ParameterType)).ToArray();
            await (Task)call.Method.Invoke(call.Target, arguments)!;
            var request = handler.Requests.Last();
            Assert.Equal(operation.GetProperty("method").GetString(), request.Method);
            var path = operation.GetProperty("path").GetString()!;
            foreach (var p in call.Method.GetParameters().Select((p, i) => (p.Name, Value: arguments[i])))
                path = path.Replace("{" + p.Name + "}", Convert.ToString(p.Value));
            Assert.Equal(path, request.Uri.AbsolutePath);
            Assert.Equal("synthetic", request.Headers["X-API-Key"]);
            Assert.False(request.Headers.ContainsKey("Authorization"));
        }
        Assert.Equal(62, handler.Requests.Count);
    }

    [Fact]
    public async Task Typed_export_to_plan_preserves_every_file()
    {
        var json = Cases().Single(c => (string)c[0] == "configuration-export-response")[2].ToString()!;
        using var handler = new RecordingHandler(request => request.Method == HttpMethod.Get ? new(HttpStatusCode.OK) { Content = new StringContent(json) } : new(HttpStatusCode.NoContent));
        using var http = new HttpClient(handler);
        using var client = new ModernEdiClient(apiKey: "synthetic", httpClient: http);
        var exported = (await client.ConfigurationAsCode.ExportIntegrationConfigurationAsync()).Data!;
        var plan = new ConfigurationPlanRequest { Files = exported.Files.Select(file => new ConfigurationPlanFile(file)).ToList() };
        await client.ConfigurationAsCode.PlanIntegrationConfigurationAsync(plan);
        var sent = JsonNode.Parse(handler.Requests.Last().Body)!;
        Assert.True(JsonNode.DeepEquals(JsonNode.Parse(json)!["files"], sent["files"]));
    }

    [Fact]
    public void Explicit_null_false_and_unknown_properties_survive()
    {
        const string json = "{\"files\":[],\"refreshScenarioBindings\":null,\"futureField\":{\"flag\":false,\"nothing\":null}}";
        var value = WireJson.Deserialize<ConfigurationPlanRequest>(json);
        Assert.True(value.RefreshScenarioBindings.IsSet);
        Assert.Null(value.RefreshScenarioBindings.Value);
        Assert.True(JsonNode.DeepEquals(JsonNode.Parse(json), JsonNode.Parse(WireJson.Serialize(value))));
        Assert.DoesNotContain("refreshScenarioBindings", WireJson.Serialize(new ConfigurationPlanRequest { Files = [] }));
    }

    [Fact]
    public async Task Xml_body_is_not_json_quoted_and_metadata_is_available()
    {
        using var handler = new RecordingHandler(_ => { var response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Headers.Add("X-Request-Id", "req-1"); response.Headers.Add("Idempotency-Replayed", "true"); response.Headers.Add("ETag", "\"tag\""); return response; });
        using var http = new HttpClient(handler);
        using var client = new ModernEdiClient(apiKey: "synthetic", httpClient: http);
        var result = await client.OutboundAs2.SendAs2MessageAsync(RequestBody.Text("<invoice>é</invoice>\r\n", "application/xml"), 1, "4010", "IN", 810, test: true);
        Assert.Equal("<invoice>é</invoice>\r\n", Encoding.UTF8.GetString(handler.Requests[0].Body));
        Assert.Equal("application/xml", handler.Requests[0].ContentType);
        Assert.Contains("test=true", handler.Requests[0].Uri.Query);
        Assert.Equal("req-1", result.RequestId); Assert.True(result.IdempotencyReplayed); Assert.Equal("\"tag\"", result.ETag);
    }

    [Fact]
    public async Task Errors_retries_and_auth_are_bounded()
    {
        using var handler = new RecordingHandler(_ => new(HttpStatusCode.ServiceUnavailable) { Content = new StringContent("{\"error\":{\"code\":\"busy\",\"message\":\"Try later\",\"requestId\":\"req-error\",\"retryable\":true}}") });
        using var http = new HttpClient(handler);
        using var client = new ModernEdiClient(bearerToken: "synthetic", httpClient: http, retry: new() { BaseDelay = TimeSpan.Zero });
        var error = await Assert.ThrowsAsync<ModernEdiApiException>(() => client.Account.GetIntegrationUsageAsync());
        Assert.Equal(3, handler.Requests.Count); Assert.Equal("busy", error.Code); Assert.True(error.Retryable); Assert.Equal("req-error", error.RequestId);
        Assert.Equal("Bearer synthetic", handler.Requests[0].Headers["Authorization"]); Assert.False(handler.Requests[0].Headers.ContainsKey("X-API-Key"));
    }

    [Fact]
    public async Task Repeated_typed_filters_use_wire_values()
    {
        using var handler = new RecordingHandler(_ => new(HttpStatusCode.NoContent));
        using var http = new HttpClient(handler);
        using var client = new ModernEdiClient(apiKey: "synthetic", httpClient: http);
        await client.Transactions.ListIntegrationTransactionsAsync(mappingStatus: [FilterableTransactionMappingStatus.FAILED, FilterableTransactionMappingStatus.RECOVERED]);
        Assert.Contains("mappingStatus=FAILED&mappingStatus=RECOVERED", handler.Requests[0].Uri.Query);
    }

    [Fact]
    public async Task Retry_after_is_not_shortened_and_paths_are_encoded()
    {
        using var handler = new RecordingHandler(_ => { var response = new HttpResponseMessage(HttpStatusCode.TooManyRequests); response.Headers.Add("Retry-After", "60"); return response; });
        using var http = new HttpClient(handler);
        using var client = new ModernEdiClient(apiKey: "synthetic", httpClient: http, retry: new() { BaseDelay = TimeSpan.Zero });
        var error = await Assert.ThrowsAsync<ModernEdiApiException>(() => client.ScenarioRuns.GetScenarioRunAsync("run/a?#b"));
        Assert.Single(handler.Requests); Assert.Equal("60", error.RetryAfter);
        Assert.Contains("run%2Fa%3F%23b", handler.Requests[0].Uri.AbsoluteUri);
    }

    [Theory]
    [InlineData(false, false, 1)]
    [InlineData(true, false, 1)]
    [InlineData(true, true, 3)]
    public async Task Mutation_retries_require_opt_in_and_supported_identity(bool retry, bool identity, int expected)
    {
        using var handler = new RecordingHandler(_ => new(HttpStatusCode.ServiceUnavailable));
        using var http = new HttpClient(handler);
        using var client = new ModernEdiClient(apiKey: "synthetic", httpClient: http, retry: retry ? new() { BaseDelay = TimeSpan.Zero } : null);
        await Assert.ThrowsAsync<ModernEdiApiException>(() => client.ScenarioRuns.StartScenarioRunAsync(new(), identity ? "command-1" : null!));
        Assert.Equal(expected, handler.Requests.Count);
    }

    [Fact]
    public async Task Unsupported_idempotency_header_does_not_enable_mutation_retries()
    {
        using var handler = new RecordingHandler(_ => new(HttpStatusCode.ServiceUnavailable));
        using var http = new HttpClient(handler);
        using var client = new ModernEdiClient(apiKey: "synthetic", httpClient: http, retry: new() { BaseDelay = TimeSpan.Zero });
        await Assert.ThrowsAsync<ModernEdiApiException>(() => client.MappedOutputs.TestMappedOutputWebhookAsync(1,
            options: new() { Headers = new Dictionary<string, string> { ["Idempotency-Key"] = "not-supported-here" } }));
        Assert.Single(handler.Requests);
    }

    [Theory]
    [InlineData(HttpStatusCode.ServiceUnavailable, 3)]
    [InlineData(HttpStatusCode.Conflict, 1)]
    public async Task Plan_retries_but_conflicts_do_not(HttpStatusCode status, int expected)
    {
        using var handler = new RecordingHandler(_ => new(status));
        using var http = new HttpClient(handler);
        using var client = new ModernEdiClient(apiKey: "synthetic", httpClient: http, retry: new() { BaseDelay = TimeSpan.Zero });
        await Assert.ThrowsAsync<ModernEdiApiException>(() => client.ConfigurationAsCode.PlanIntegrationConfigurationAsync(new()));
        Assert.Equal(expected, handler.Requests.Count);
    }

    [Fact]
    public async Task Evidence_digest_uses_original_bytes()
    {
        var evidence = Cases().First(row => (string)row[1] == "ScenarioEvidenceReport");
        var raw = Encoding.UTF8.GetBytes((string)evidence[2] + "\n");
        var digest = Convert.ToHexString(SHA256.HashData(raw)).ToLowerInvariant();
        using var handler = new RecordingHandler(_ => {
            var response = new HttpResponseMessage(HttpStatusCode.OK) { Content = new ByteArrayContent(raw) };
            response.Headers.Add("X-Content-SHA256", digest); return response;
        });
        using var http = new HttpClient(handler);
        using var client = new ModernEdiClient(apiKey: "synthetic", httpClient: http);
        var result = await client.ScenarioRuns.DownloadScenarioEvidenceReportAsync("run-1");
        Assert.Equal(result.ContentSha256, Convert.ToHexString(SHA256.HashData(result.RawBody.Span)).ToLowerInvariant());
        Assert.True(JsonNode.DeepEquals(JsonNode.Parse((string)evidence[2]), JsonNode.Parse(WireJson.Serialize(result.Data))));
    }
}

internal sealed record RecordedRequest(string Method, Uri Uri, Dictionary<string, string> Headers, byte[] Body, string? ContentType);
internal sealed class RecordingHandler(Func<HttpRequestMessage, HttpResponseMessage> respond) : HttpMessageHandler
{
    internal List<RecordedRequest> Requests { get; } = [];
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        Requests.Add(new(request.Method.Method, request.RequestUri!, request.Headers.ToDictionary(h => h.Key, h => string.Join(",", h.Value), StringComparer.OrdinalIgnoreCase),
            request.Content is null ? [] : await request.Content.ReadAsByteArrayAsync(cancellationToken), request.Content?.Headers.ContentType?.ToString()));
        return respond(request);
    }
}
