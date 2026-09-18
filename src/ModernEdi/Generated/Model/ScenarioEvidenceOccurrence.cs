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

public sealed class ScenarioEvidenceOccurrence
{
    /// <summary></summary>
    [JsonPropertyName("occurrence")]
    [JsonRequired]
    public int Occurrence { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("observedAt")]
    [JsonRequired]
    public string ObservedAt { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string MessageId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("transactionKey")]
    [JsonRequired]
    public string TransactionKey { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("partnerId")]
    [JsonRequired]
    public long PartnerId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("mappingId")]
    [JsonRequired]
    public long? MappingId { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
