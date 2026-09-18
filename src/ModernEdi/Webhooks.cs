using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace ModernEdi;

public sealed class WebhookVerificationException : Exception
{
    public string Code { get; }
    public WebhookVerificationException(string code, string message) : base(message) { Code = code; }
}

public static class Webhooks
{
    /// <summary>Verifies original request bytes. Durably deduplicate deliveryId and message.id after verification.</summary>
    public static JsonElement VerifyMappedOutput(ReadOnlySpan<byte> rawBody,
        IEnumerable<KeyValuePair<string, string>> headers, string signingSecret,
        TimeSpan? tolerance = null, DateTimeOffset? now = null)
    {
        ArgumentException.ThrowIfNullOrEmpty(signingSecret);
        var window = tolerance ?? TimeSpan.FromMinutes(5);
        if (window < TimeSpan.Zero) throw new ArgumentOutOfRangeException(nameof(tolerance));
        var values = headers.ToArray();
        var timestamp = Header(values, "X-ModernEDI-Timestamp");
        var signature = Header(values, "X-ModernEDI-Signature");
        var eventType = Header(values, "X-ModernEDI-Event");
        var deliveryId = Header(values, "X-ModernEDI-Delivery-Id");
        if (!Regex.IsMatch(timestamp, @"\A(?:0|[1-9][0-9]*)\z", RegexOptions.CultureInvariant) ||
            !long.TryParse(timestamp, NumberStyles.None, CultureInfo.InvariantCulture, out var seconds) || seconds > 9007199254740991L)
            throw Error("invalid_timestamp", "Expected whole Unix epoch seconds.");
        if (Math.Abs((double)(now ?? DateTimeOffset.UtcNow).ToUnixTimeSeconds() - seconds) > window.TotalSeconds)
            throw Error("timestamp_outside_tolerance", "Webhook timestamp is outside the accepted window.");
        if (!Regex.IsMatch(signature, @"\Asha256=[0-9a-f]{64}\z", RegexOptions.CultureInvariant))
            throw Error("invalid_signature_format", "Expected sha256 and 64 lowercase hexadecimal characters.");
        using var hmac = IncrementalHash.CreateHMAC(HashAlgorithmName.SHA256, Encoding.UTF8.GetBytes(signingSecret));
        hmac.AppendData(Encoding.ASCII.GetBytes(timestamp + ".")); hmac.AppendData(rawBody);
        if (!CryptographicOperations.FixedTimeEquals(hmac.GetHashAndReset(), Convert.FromHexString(signature[7..])))
            throw Error("signature_mismatch", "Webhook signature does not match.");
        JsonDocument document;
        try { document = JsonDocument.Parse(rawBody.ToArray()); }
        catch (JsonException) { throw Error("invalid_json", "Verified body is not JSON."); }
        using (document)
        {
            var value = document.RootElement;
            var valid = value.ValueKind == JsonValueKind.Object && Text(value, "createdAt") &&
                Text(value, "deliveryId") && Integer(value, "tenantId", 1) && Integer(value, "partnerId", 1) &&
                Text(value, "event") && value.GetProperty("event").GetString() == eventType && value.GetProperty("deliveryId").GetString() == deliveryId;
            if (!valid) throw Error("invalid_event", "Verified body does not match a mapped-output event.");
            if (eventType == "mapped_output.test")
                valid = value.TryGetProperty("test", out var test) && test.ValueKind == JsonValueKind.True && !value.TryGetProperty("message", out _) && Text(value, "requestId") && Text(value, "description");
            else if (eventType == "mapped_output.available")
                valid = value.TryGetProperty("message", out var message) && message.ValueKind == JsonValueKind.Object &&
                    new[] { "id", "receiptHandle", "messageId", "transactionKey", "environment", "mappedOutputKey", "purpose" }.All(key => Text(message, key)) &&
                    Integer(message, "deliveryCount", 0) && Integer(message, "sequenceNumber", 0);
            else valid = false;
            if (!valid) throw Error("invalid_event", "Verified body does not match a mapped-output event.");
            return value.Clone();
        }
    }

    private static bool Text(JsonElement value, string key) => value.TryGetProperty(key, out var field) && field.ValueKind == JsonValueKind.String && !string.IsNullOrEmpty(field.GetString());
    private static bool Integer(JsonElement value, string key, long minimum) => value.TryGetProperty(key, out var field) && field.ValueKind == JsonValueKind.Number && field.TryGetInt64(out var number) && number >= minimum && number <= 9007199254740991L;
    private static string Header(KeyValuePair<string, string>[] headers, string name)
    {
        var values = headers.Where(h => h.Key.Equals(name, StringComparison.OrdinalIgnoreCase)).Select(h => h.Value).ToArray();
        if (values.Length > 1 || values.Any(v => v.Contains(','))) throw Error("duplicate_header", $"{name} must occur exactly once.");
        if (values.Length == 0 || string.IsNullOrEmpty(values[0])) throw Error("missing_header", $"Required header {name} is missing.");
        return values[0];
    }
    private static WebhookVerificationException Error(string code, string message) => new(code, message);
}
