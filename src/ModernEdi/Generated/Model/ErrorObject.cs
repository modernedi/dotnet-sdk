// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Stable machine-readable error details returned for a failed Integration API request.</summary>

public sealed class ErrorObject
{
    /// <summary>Stable machine-readable error code; branch on this value rather than parsing &#x60;message&#x60;.</summary>
    [JsonPropertyName("code")]
    [JsonRequired]
    public string Code { get; set; } = default!;

    /// <summary>Customer-readable explanation suitable for logs or an operator-facing error message.</summary>
    [JsonPropertyName("message")]
    [JsonRequired]
    public string Message { get; set; } = default!;

    /// <summary>Whether retrying the same operation later may succeed without changing the request.</summary>
    [JsonPropertyName("retryable")]
    [JsonRequired]
    public bool Retryable { get; set; } = default!;

    /// <summary>Correlation identifier also returned in &#x60;X-Request-Id&#x60;; include it when contacting ModernEDI Support.</summary>
    [JsonPropertyName("requestId")]
    [JsonRequired]
    public string RequestId { get; set; } = default!;

    /// <summary>Error-specific structured context such as field paths, limits, required scopes, or entitlement details.</summary>
    [JsonPropertyName("details")]
    [JsonRequired]
    public Dictionary<string, Object> Details { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
