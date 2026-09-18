// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One applied scenario binding whose executable authority depends on a changed resource.</summary>

public sealed class ConfigurationPlanAffectedScenario
{
    /// <summary>Stable scenario binding identifier.</summary>
    [JsonPropertyName("bindingId")]
    [JsonRequired]
    public string BindingId { get; set; } = default!;

    /// <summary>Applied immutable binding revision.</summary>
    [JsonPropertyName("revision")]
    [JsonRequired]
    public long Revision { get; set; } = default!;

    /// <summary>Customer-facing binding name.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("definition")]
    [JsonRequired]
    public ConfigurationPlanScenarioDefinition Definition { get; set; } = default!;

    /// <summary>REAPPLIED_BY_APPLY refreshes the binding&#39;s frozen authority in this aggregate apply; RETIRED_BY_APPLY removes it from current configuration while preserving its history; REAPPLY_REQUIRED identifies a binding outside the desired configuration that needs a separate refresh.</summary>
    [JsonPropertyName("effect")]
    [JsonRequired]
    public string Effect { get; set; } = default!;

    /// <summary>Planned changes responsible for this scenario effect.</summary>
    [JsonPropertyName("resources")]
    [JsonRequired]
    public List<ConfigurationPlanScenarioResource> Resources { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
