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

public sealed class ScenarioEvidenceReport
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    [JsonRequired]
    public string ApiVersion { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    [JsonRequired]
    public string CreatedAt { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("claim")]
    [JsonRequired]
    public ScenarioEvidenceClaim Claim { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("run")]
    [JsonRequired]
    public ScenarioEvidenceRun Run { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("binding")]
    [JsonRequired]
    public ScenarioEvidenceBinding Binding { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("operations")]
    [JsonRequired]
    public ScenarioEvidenceOperations Operations { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("evidence")]
    [JsonRequired]
    public ScenarioEvidence Evidence { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
