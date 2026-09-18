// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Result of one synthetic webhook connectivity attempt. This response never represents or changes a real mapped output.</summary>

public sealed class MappedOutputWebhookTestResponse
{
    /// <summary>The ModernEDI test operation completed. This does not mean the destination accepted the event; inspect &#x60;delivered&#x60;.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary>Always true so this result cannot be mistaken for production mapped-output delivery.</summary>
    [JsonPropertyName("synthetic")]
    [JsonRequired]
    public bool Synthetic { get; set; } = default!;

    /// <summary>Synthetic event name sent in both the signed body and &#x60;X-ModernEDI-Event&#x60; header.</summary>
    [JsonPropertyName("event")]
    [JsonRequired]
    public string Event { get; set; } = default!;

    /// <summary>Synthetic &#x60;test_&#x60;-prefixed delivery correlation id. It is not a mapped-output queue id or receipt handle.</summary>
    [JsonPropertyName("deliveryId")]
    [JsonRequired]
    public string DeliveryId { get; set; } = default!;

    /// <summary>Request correlation id returned in &#x60;X-Request-Id&#x60; and included in the signed synthetic event.</summary>
    [JsonPropertyName("requestId")]
    [JsonRequired]
    public string RequestId { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;.</summary>
    [JsonPropertyName("attemptedAt")]
    [JsonRequired]
    public string AttemptedAt { get; set; } = default!;

    /// <summary>Always true because ModernEDI invoked the validated delivery path. A null &#x60;statusCode&#x60; means the path failed before an HTTP response was received.</summary>
    [JsonPropertyName("attempted")]
    [JsonRequired]
    public bool Attempted { get; set; } = default!;

    /// <summary>True only when the destination returned HTTP 2xx. A &#x60;200&#x60; from this ModernEDI API operation can still contain &#x60;delivered: false&#x60;. </summary>
    [JsonPropertyName("delivered")]
    [JsonRequired]
    public bool Delivered { get; set; } = default!;

    /// <summary>Destination HTTP status, or null when public-address validation, DNS, connection, TLS, or timeout failure prevented an HTTP response. </summary>
    [JsonPropertyName("statusCode")]
    [JsonRequired]
    public int? StatusCode { get; set; } = default!;

    /// <summary>Safe delivery failure summary, or null when &#x60;delivered&#x60; is true.</summary>
    [JsonPropertyName("error")]
    [JsonRequired]
    public string? Error { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
