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

public sealed class ScenarioRunSummaryGuidanceOneOf
{
    /// <summary></summary>
    [JsonPropertyName("nextAction")]
    [JsonRequired]
    public string? NextAction { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("stepId")]
    [JsonRequired]
    public string? StepId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("occurrence")]
    [JsonRequired]
    public string? Occurrence { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
