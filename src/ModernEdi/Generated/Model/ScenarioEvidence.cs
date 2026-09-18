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

public sealed class ScenarioEvidence
{
    /// <summary></summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("counts")]
    [JsonRequired]
    public ScenarioEvidenceCounts Counts { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("steps")]
    [JsonRequired]
    public List<ScenarioEvidenceStep> Steps { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("checks")]
    [JsonRequired]
    public List<ScenarioEvidenceCheck> Checks { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("references")]
    [JsonRequired]
    public List<ScenarioEvidenceReference> References { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
