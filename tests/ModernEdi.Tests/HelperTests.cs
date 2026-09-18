using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Xunit;

namespace ModernEdi.Tests;

public class HelperTests
{
    private const long Now = 1800000000;
    private const string Secret = "synthetic-webhook-secret";
    private const string Event = "{\"event\":\"mapped_output.test\",\"deliveryId\":\"delivery-1\",\"createdAt\":\"2027-01-15T08:00:00.123456789Z\",\"tenantId\":1,\"partnerId\":2,\"test\":true,\"requestId\":\"req-1\",\"description\":\"Synthetic é event\"}";
    private static Dictionary<string, string> Signed(byte[] bytes) => new(StringComparer.OrdinalIgnoreCase)
    {
        ["X-ModernEDI-Timestamp"] = Now.ToString(), ["X-ModernEDI-Event"] = "mapped_output.test", ["X-ModernEDI-Delivery-Id"] = "delivery-1",
        ["X-ModernEDI-Signature"] = "sha256=" + Convert.ToHexString(HMACSHA256.HashData(Encoding.UTF8.GetBytes(Secret), Encoding.UTF8.GetBytes(Now + ".").Concat(bytes).ToArray())).ToLowerInvariant()
    };

    [Fact]
    public void Verifies_original_bytes_and_preserves_nanoseconds()
    {
        var bytes = Encoding.UTF8.GetBytes(Event);
        var value = Webhooks.VerifyMappedOutput(bytes, Signed(bytes), Secret, now: DateTimeOffset.FromUnixTimeSeconds(Now));
        Assert.Equal("2027-01-15T08:00:00.123456789Z", value.GetProperty("createdAt").GetString());
        Assert.True(JsonNode.DeepEquals(JsonNode.Parse(Event), JsonNode.Parse(value.GetRawText())));
    }

    [Theory]
    [InlineData("X-ModernEDI-Timestamp", "1799999699", "timestamp_outside_tolerance")]
    [InlineData("X-ModernEDI-Timestamp", "1800000301", "timestamp_outside_tolerance")]
    [InlineData("X-ModernEDI-Timestamp", "01", "invalid_timestamp")]
    [InlineData("X-ModernEDI-Signature", "sha256=bad", "invalid_signature_format")]
    [InlineData("X-ModernEDI-Signature", "sha256=0000000000000000000000000000000000000000000000000000000000000000\n", "invalid_signature_format")]
    [InlineData("X-ModernEDI-Signature", "sha256=0000000000000000000000000000000000000000000000000000000000000000", "signature_mismatch")]
    [InlineData("X-ModernEDI-Delivery-Id", "mismatch", "invalid_event")]
    [InlineData("X-ModernEDI-Event", "mapped_output.test,extra", "duplicate_header")]
    public void Rejects_invalid_headers(string name, string value, string code)
    {
        var bytes = Encoding.UTF8.GetBytes(Event); var headers = Signed(bytes); headers[name] = value;
        Assert.Equal(code, Assert.Throws<WebhookVerificationException>(() => Webhooks.VerifyMappedOutput(bytes, headers, Secret,
            now: DateTimeOffset.FromUnixTimeSeconds(Now))).Code);
    }

    [Theory]
    [InlineData("not json", "invalid_json")]
    [InlineData("{}", "invalid_event")]
    [InlineData("{\"event\":\"unknown\"}", "invalid_event")]
    public void Rejects_invalid_signed_bodies(string json, string code)
    {
        var bytes = Encoding.UTF8.GetBytes(json);
        Assert.Equal(code, Assert.Throws<WebhookVerificationException>(() => Webhooks.VerifyMappedOutput(bytes, Signed(bytes), Secret,
            now: DateTimeOffset.FromUnixTimeSeconds(Now))).Code);
    }

    [Fact]
    public void Rejects_duplicates_and_missing_headers()
    {
        var bytes = Encoding.UTF8.GetBytes(Event); var headers = Signed(bytes).ToList(); headers.Add(new("x-modernedi-signature", "duplicate"));
        Assert.Equal("duplicate_header", Assert.Throws<WebhookVerificationException>(() => Webhooks.VerifyMappedOutput(bytes, headers, Secret, now: DateTimeOffset.FromUnixTimeSeconds(Now))).Code);
        Assert.Equal("missing_header", Assert.Throws<WebhookVerificationException>(() => Webhooks.VerifyMappedOutput(bytes, [], Secret)).Code);
    }

    [Fact]
    public async Task Pagination_preserves_opaque_cursor_and_detects_cycles()
    {
        var calls = new List<string?>();
        Task<(int[] Items, string? Next)> Load(string? cursor, CancellationToken cancellation)
        { calls.Add(cursor); return Task.FromResult((new[] { calls.Count }, cursor is null ? "opaque/+==?#" : null)); }
        var output = new List<int>();
        await foreach (var value in Pagination.CursorAsync(Load, p => p.Items, p => p.Next)) output.Add(value);
        Assert.Equal([1, 2], output); Assert.Equal([null, "opaque/+==?#"], calls);
        await Assert.ThrowsAsync<InvalidOperationException>(async () => {
            await foreach (var _ in Pagination.CursorAsync<string, int>((_, _) => Task.FromResult("repeat"), _ => [1], p => p)) { }
        });
    }

    [Fact]
    public async Task Pagination_honors_limit_and_cancellation()
    {
        var count = 0;
        await foreach (var _ in Pagination.CursorAsync<string, int>((_, _) => Task.FromResult("repeat"), _ => [1], p => p, maxPages: 1)) count++;
        Assert.Equal(1, count);
        using var cancellation = new CancellationTokenSource(); cancellation.Cancel();
        await Assert.ThrowsAsync<OperationCanceledException>(async () => {
            await foreach (var _ in Pagination.CursorAsync<string, int>((_, _) => throw new Exception("Must not call"), _ => [], _ => null, cancellationToken: cancellation.Token)) { }
        });
    }
}
