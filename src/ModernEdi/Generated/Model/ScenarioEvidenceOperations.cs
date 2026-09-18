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

public sealed class ScenarioEvidenceOperations
{
    /// <summary></summary>
    [JsonPropertyName("total")]
    [JsonRequired]
    public int Total { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("succeeded")]
    [JsonRequired]
    public int Succeeded { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("failed")]
    [JsonRequired]
    public int Failed { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("successfulTransitions")]
    [JsonRequired]
    public List<ScenarioEvidenceSuccessfulTransition> SuccessfulTransitions { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("failures")]
    [JsonRequired]
    public List<ScenarioEvidenceFailure> Failures { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
