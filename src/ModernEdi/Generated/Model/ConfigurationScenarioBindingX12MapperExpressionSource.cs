// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Evaluates one ordinary X12 Mapper expression against the step transaction. Validate and Apply use the same parser, semantic validator, function registry, budget mechanism, and syntax-tree-aware engine as runtime mappings and primaryKeyExtractor, with scenario-specific bounded limits. Validate and Apply reject an expression that is statically incapable of reading an X12 segment or element, and runtime fails closed when the executed path produces no concrete X12 read. Scenario evidence uses that engine&#39;s element-read tracing facility; this does not imply that existing primary-key persistence emits the same trace. The ScenarioDefinition remains authoritative for value type, cardinality, normalization, and sensitivity.</summary>

public sealed class ConfigurationScenarioBindingX12MapperExpressionSource
{
    /// <summary>Uses ModernEDI&#39;s existing X12 Mapper expression language and engine, shared with primaryKeyExtractor.</summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary>One value-returning X12 Mapper expression that reads at least one X12 segment or element. A constant-only expression cannot provide authoritative document evidence. Scalars, lists, and sets are interpreted according to the matching fact declaration; secrets and credentials must never appear here.</summary>
    [JsonPropertyName("expression")]
    [JsonRequired]
    public string Expression { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
