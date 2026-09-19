using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Xunit;

namespace ModernEdi.Tests;

public class RetryBehaviorTests
{
    private static readonly JsonElement Corpus = JsonSerializer.Deserialize<JsonElement>(File.ReadAllText(
        Path.Combine(AppContext.BaseDirectory, "fixtures/retry-behavior.json")));

    public static IEnumerable<object[]> Cases() => Corpus.GetProperty("cases").EnumerateArray()
        .Select(row => new object[] { row.GetProperty("id").GetString()!, row.Clone() });

    [Theory, MemberData(nameof(Cases))]
    public async Task Shared_retry_behavior(string id, JsonElement row)
    {
        var operationId = row.GetProperty("operationId").GetString()!;
        var request = Corpus.GetProperty("requests").GetProperty(operationId);
        var responses = row.GetProperty("responses").EnumerateArray().ToArray();
        var attempts = 0;
        using var handler = new RecordingHandler(sent => {
            var response = responses[Math.Min(attempts++, responses.Length - 1)];
            if (response.TryGetProperty("networkError", out _)) throw new HttpRequestException("Synthetic network failure");
            var result = new HttpResponseMessage((HttpStatusCode)response.GetProperty("status").GetInt32());
            if (response.TryGetProperty("headers", out var headers))
                foreach (var header in headers.EnumerateObject()) result.Headers.TryAddWithoutValidation(header.Name, header.Value.GetString());
            return result;
        });
        using var http = new HttpClient(handler);
        using var client = new ModernEdiClient(apiKey: Corpus.GetProperty("apiKey").GetString(),
            baseUrl: Corpus.GetProperty("baseUrl").GetString()!, httpClient: http,
            retry: row.TryGetProperty("retry", out var retry) && !retry.GetBoolean() ? null : new() { BaseDelay = TimeSpan.Zero });
        var options = new RequestOptions { Headers = row.TryGetProperty("headers", out var optionHeaders)
            ? optionHeaders.EnumerateObject().ToDictionary(h => h.Name, h => h.Value.GetString()!) : new Dictionary<string, string>() };
        var key = row.TryGetProperty("idempotencyKey", out var keyValue) ? keyValue.GetString() : null;
        var parameters = request.GetProperty("parameters");
        int? status = null;
        ApiResponse<ModernEdi.Model.ConfigurationExportResponse>? export = null;
        Exception? failure = null;
        try
        {
            status = operationId switch {
                "getIntegrationUsage" => (await client.Account.GetIntegrationUsageAsync(options: options)).StatusCode,
                "exportIntegrationConfiguration" => (export = await client.ConfigurationAsCode.ExportIntegrationConfigurationAsync(
                    ifNoneMatch: parameters.GetProperty("ifNoneMatch").GetString(), options: options)).StatusCode,
                "pollMappedOutputs" => (await client.MappedOutputs.PollMappedOutputsAsync(
                    environment: parameters.GetProperty("environment").GetString(), options: options)).StatusCode,
                "planIntegrationConfiguration" => (await client.ConfigurationAsCode.PlanIntegrationConfigurationAsync(
                    WireJson.Deserialize<ModernEdi.Model.ConfigurationPlanRequest>(request.GetProperty("body").GetRawText())!, options: options)).StatusCode,
                "testMappedOutputWebhook" => (await client.MappedOutputs.TestMappedOutputWebhookAsync(parameters.GetProperty("partnerId").GetInt32(), options: options)).StatusCode,
                "sendGeneratedX12Message" => (await client.OutboundAs2.SendGeneratedX12MessageAsync(
                    RequestBody.Text(request.GetProperty("body").GetString()!, request.GetProperty("contentType").GetString()!),
                    parameters.GetProperty("partnerId").GetInt32(), parameters.GetProperty("x12Version").GetString()!,
                    parameters.GetProperty("functionalGroupType").GetString()!, parameters.GetProperty("transactionGroupType").GetInt32(),
                    test: parameters.GetProperty("test").GetBoolean(), idempotencyKey: key, options: options)).StatusCode,
                "watchIntegrationTransaction" => (await client.Transactions.WatchIntegrationTransactionAsync(
                    parameters.GetProperty("messageId").GetString()!, parameters.GetProperty("transactionKey").GetString()!,
                    environment: parameters.GetProperty("environment").GetString(), options: options)).StatusCode,
                "unwatchIntegrationTransaction" => (await client.Transactions.UnwatchIntegrationTransactionAsync(
                    parameters.GetProperty("messageId").GetString()!, parameters.GetProperty("transactionKey").GetString()!,
                    environment: parameters.GetProperty("environment").GetString(), options: options)).StatusCode,
                _ => throw new InvalidOperationException("Missing shared behavior adapter: " + operationId)
            };
        }
        catch (Exception error) when (error is ModernEdiApiException or HttpRequestException) { failure = error; }

        Assert.Equal(row.GetProperty("attempts").GetInt32(), handler.Requests.Count);
        foreach (var sent in handler.Requests)
        {
            Assert.Equal(request.GetProperty("method").GetString(), sent.Method);
            Assert.Equal("/edi" + request.GetProperty("path").GetString(), sent.Uri.AbsolutePath);
            Assert.Equal(Corpus.GetProperty("apiKey").GetString(), sent.Headers["X-API-Key"]);
            Assert.False(sent.Headers.ContainsKey("Authorization"));
            Assert.Equal((key ?? options.Headers.Values.FirstOrDefault() ?? "").Trim(), sent.Headers.GetValueOrDefault("Idempotency-Key", "").Trim());
            Assert.Equal(handler.Requests[0].Uri, sent.Uri);
            Assert.Equal(handler.Requests[0].Body, sent.Body);
            if (request.TryGetProperty("contentType", out _)) Assert.Equal(request.GetProperty("body").GetString(), Encoding.UTF8.GetString(sent.Body));
            else if (request.TryGetProperty("body", out var body)) Assert.True(JsonNode.DeepEquals(JsonNode.Parse(body.GetRawText()), JsonNode.Parse(sent.Body)), id);
        }
        if (row.TryGetProperty("networkError", out _)) Assert.IsType<HttpRequestException>(failure);
        else if (row.GetProperty("status").GetInt32() >= 400)
        {
            var error = Assert.IsType<ModernEdiApiException>(failure);
            Assert.Equal(row.GetProperty("status").GetInt32(), error.StatusCode);
            Assert.Equal(row.TryGetProperty("retryAfter", out var after) ? after.GetString() : null, error.RetryAfter);
        }
        else {
            Assert.Null(failure); Assert.Equal(row.GetProperty("status").GetInt32(), status);
            if (row.TryGetProperty("emptyBody", out _)) { Assert.NotNull(export); Assert.Null(export.Data); Assert.True(export.RawBody.IsEmpty); }
            if (row.TryGetProperty("etag", out var etag)) Assert.Equal(etag.GetString(), export?.ETag);
        }
    }
}
