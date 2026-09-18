// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One ACTIVE scenario run whose pinned binding authority depends on a changed resource.</summary>

public sealed class ConfigurationPlanAffectedRun
{
    /// <summary>Stable scenario run identifier.</summary>
    [JsonPropertyName("runId")]
    [JsonRequired]
    public string RunId { get; set; } = default!;

    /// <summary>Stable scenario binding identifier pinned by the run.</summary>
    [JsonPropertyName("bindingId")]
    [JsonRequired]
    public string BindingId { get; set; } = default!;

    /// <summary>Immutable binding revision pinned by the active run.</summary>
    [JsonPropertyName("bindingRevision")]
    [JsonRequired]
    public long BindingRevision { get; set; } = default!;

    /// <summary>The run must leave ACTIVE state before this desired configuration can be applied.</summary>
    [JsonPropertyName("effect")]
    [JsonRequired]
    public string Effect { get; set; } = default!;

    /// <summary>Planned resource changes that intersect the run&#39;s pinned binding authority.</summary>
    [JsonPropertyName("resources")]
    [JsonRequired]
    public List<ConfigurationPlanScenarioResource> Resources { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
