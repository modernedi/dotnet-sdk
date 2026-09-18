// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary></summary>

public sealed class TransactionEventBase
{
    /// <summary>Stable event identifier within this transaction timeline.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>Machine-readable discriminator for the concrete &#x60;details&#x60; schema.</summary>
    [JsonPropertyName("type")]
    [JsonRequired]
    public string Type { get; set; } = default!;

    /// <summary>Customer-readable event title suitable for an operator timeline.</summary>
    [JsonPropertyName("label")]
    [JsonRequired]
    public string Label { get; set; } = default!;

    /// <summary>Event-specific structured context selected by &#x60;type&#x60;.</summary>
    [JsonPropertyName("details")]
    [JsonRequired]
    public Object Details { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("timestamp")]
    [JsonRequired]
    public string? Timestamp { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
