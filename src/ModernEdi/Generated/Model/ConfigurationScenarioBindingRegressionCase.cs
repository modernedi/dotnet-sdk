// Generated from the ModernEDI Integration API 1.36.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary></summary>

public sealed class ConfigurationScenarioBindingRegressionCase
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    /// <summary>Ordinary run parameters, resolved and type-checked against this exact definition.</summary>
    [JsonPropertyName("parameters")]
    [JsonRequired]
    public Object Parameters { get; set; } = default!;

    /// <summary>Listed attachment order. Repeated step IDs are assigned occurrence 1, 2, and so on. No sorting by business event time occurs.</summary>
    [JsonPropertyName("observations")]
    [JsonRequired]
    public List<ConfigurationScenarioBindingRegressionObservation> Observations { get; set; } = default!;

    /// <summary>Whole seconds after the synthetic start (at most 365 days).</summary>
    [JsonPropertyName("evaluatedAfterSeconds")]
    [JsonRequired]
    public int EvaluatedAfterSeconds { get; set; } = default!;

    /// <summary>Explicit-completion steps to close at the evaluation time. Closing never waives their checks.</summary>
    [JsonPropertyName("closeSteps")]
    [JsonRequired]
    public List<string> CloseSteps { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("expected")]
    [JsonRequired]
    public ConfigurationScenarioBindingRegressionExpected Expected { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
