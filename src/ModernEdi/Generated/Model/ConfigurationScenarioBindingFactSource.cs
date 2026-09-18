// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One ordinary X12 Mapper expression fact source. It uses the same language and execution engine as an incoming map&#39;s primaryKeyExtractor; v1 does not define a second scenario-specific selector language. The expression must read the bound X12 document so its value has concrete provenance.</summary>

public sealed class ConfigurationScenarioBindingFactSource
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
