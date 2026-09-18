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

public sealed class ScenarioEvidenceMappingAuthority
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("stepId")]
    [JsonRequired]
    public string StepId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public long Id { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("partnerId")]
    [JsonRequired]
    public long PartnerId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("direction")]
    [JsonRequired]
    public string Direction { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("x12Version")]
    [JsonRequired]
    public string X12Version { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("transactionSet")]
    [JsonRequired]
    public string TransactionSet { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("configurationEtag")]
    [JsonRequired]
    public string ConfigurationEtag { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("mapFileSha256Hash")]
    [JsonRequired]
    public string MapFileSha256Hash { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
