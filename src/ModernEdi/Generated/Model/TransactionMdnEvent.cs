// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>AS2 receipt waiting, overdue, sent, or received state.</summary>

public sealed class TransactionMdnEvent
{
    /// <summary>Stable event identifier within this transaction timeline.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>Identifies the waiting, overdue, sent, or received AS2 receipt transition.</summary>
    [JsonPropertyName("type")]
    [JsonRequired]
    public string Type { get; set; } = default!;

    /// <summary>Customer-readable event title suitable for an operator timeline.</summary>
    [JsonPropertyName("label")]
    [JsonRequired]
    public string Label { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("details")]
    [JsonRequired]
    public TransactionMdnEventDetails Details { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("timestamp")]
    [JsonRequired]
    public string? Timestamp { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
