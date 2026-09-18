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

public sealed class CorrelationMatching
{
    /// <summary>Pair occurrences whose declared correlation conditions pass.</summary>
    [JsonPropertyName("strategy")]
    [JsonRequired]
    public string Strategy { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("quantifiers")]
    [JsonRequired]
    public List<ConfigurationScenarioDefinitionMatchQuantifier> Quantifiers { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("unmatched")]
    [JsonRequired]
    public string Unmatched { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
