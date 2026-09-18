// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>How many documents this step may contribute to one run and the rule that says when no more are expected. One observed document is one occurrence. For example, an 850 order can be exactly once while 856 shipment notices can repeat. The server also enforces min &lt;&#x3D; max.</summary>

public sealed class ConfigurationScenarioDefinitionOccurrence
{
    /// <summary>Minimum accepted count once a reachable step closes. Zero is a no-document outcome only when expected_count resolves to 0 or branch selection makes the step unreachable; zero alone does not close a stream.</summary>
    [JsonPropertyName("min")]
    [JsonRequired]
    public int Min { get; set; } = default!;

    /// <summary>Structural per-step ceiling for authored occurrences. Validate and Apply also enforce one conservative run-state capacity budget across all steps, paired documents, checks, and durable evidence.</summary>
    [JsonPropertyName("max")]
    [JsonRequired]
    public int Max { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("closure")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<ConfigurationScenarioDefinitionOccurrenceClosure> Closure { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
