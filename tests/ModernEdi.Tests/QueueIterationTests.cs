using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Xunit;

namespace ModernEdi.Tests;

public class QueueIterationTests
{
    private static readonly JsonNode Corpus = JsonNode.Parse(File.ReadAllText(
        Path.Combine(AppContext.BaseDirectory, "fixtures/queue-iteration.json")))!;

    [Fact]
    public async Task Shared_queue_traces_preserve_cursors_and_bound_polls()
    {
        foreach (var row in Corpus["cases"]!.AsArray())
        {
            var pages = row!["pages"]!.AsArray();
            var polls = 0;
            string? expectedCursor = row["cursor"]?.GetValue<string>();
            using var handler = new RecordingHandler(request => {
                var query = request.RequestUri!.Query;
                if (expectedCursor is null) Assert.DoesNotContain("cursor=", query);
                else Assert.Contains("cursor=" + Uri.EscapeDataString(expectedCursor), query);
                var page = pages[Math.Min(polls++, pages.Count - 1)]!;
                expectedCursor = page["nextCursor"]?.GetValue<string>();
                var messages = new JsonArray();
                foreach (var id in page["items"]!.AsArray())
                {
                    var message = Corpus["message"]!.DeepClone();
                    message["id"] = id!.GetValue<string>();
                    messages.Add(message);
                }
                return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(new JsonObject {
                    ["success"] = true, ["environment"] = "test", ["limit"] = 1, ["visibilityTimeoutSeconds"] = 120,
                    ["messages"] = messages, ["nextCursor"] = expectedCursor, ["hasMore"] = expectedCursor is not null
                }.ToJsonString(), Encoding.UTF8, "application/json") };
            });
            using var http = new HttpClient(handler);
            using var client = new ModernEdiClient(apiKey: "synthetic", httpClient: http);
            var actual = new List<string>();
            await foreach (var item in Pagination.MappedOutputsAsync(
                (cursor, token) => client.MappedOutputs.PollMappedOutputsAsync(cursor: cursor, environment: "test", cancellationToken: token),
                cursor: row["cursor"]?.GetValue<string>(), maxPolls: row["maxPolls"]!.GetValue<int>())) actual.Add(item.Id);
            Assert.Equal(row["expected"]!.Deserialize<string[]>(), actual);
            Assert.Equal(row["polls"]!.GetValue<int>(), polls);
        }
    }

    [Fact]
    public async Task Invalid_bounds_cancellation_and_poll_errors_are_not_hidden()
    {
        using var http = new HttpClient(new RecordingHandler(_ => throw new HttpRequestException("lost poll response")));
        using var client = new ModernEdiClient(apiKey: "synthetic", httpClient: http);
        foreach (var limit in new[] { 0, -1 })
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () => {
                await foreach (var _ in Pagination.MappedOutputsAsync((cursor, token) =>
                    client.MappedOutputs.PollMappedOutputsAsync(cursor: cursor, cancellationToken: token), maxPolls: limit)) { }
            });
        await Assert.ThrowsAsync<HttpRequestException>(async () => {
            await foreach (var _ in Pagination.MappedOutputsAsync((cursor, token) =>
                client.MappedOutputs.PollMappedOutputsAsync(cursor: cursor, cancellationToken: token))) { }
        });
        await Assert.ThrowsAnyAsync<OperationCanceledException>(async () => {
            await foreach (var _ in Pagination.MappedOutputsAsync((cursor, token) =>
                client.MappedOutputs.PollMappedOutputsAsync(cursor: cursor, cancellationToken: token), cancellationToken: new(true))) { }
        });
    }
}
