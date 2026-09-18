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

public sealed class ScenarioEvidenceSyntaxTreeAuthority
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("stepId")]
    [JsonRequired]
    public string StepId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("x12Version")]
    [JsonRequired]
    public string X12Version { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("transactionSet")]
    [JsonRequired]
    public string TransactionSet { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("catalogRevision")]
    [JsonRequired]
    public string CatalogRevision { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("catalogManifestSha256")]
    [JsonRequired]
    public string CatalogManifestSha256 { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("syntaxTreeSha256")]
    [JsonRequired]
    public string SyntaxTreeSha256 { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
