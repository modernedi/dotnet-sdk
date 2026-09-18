// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Stable semantic ABI for one fact exposed by a step occurrence. The binding/runtime capability separately defines extraction provenance.</summary>

public sealed class ConfigurationScenarioDefinitionFactDeclaration
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("type")]
    [JsonRequired]
    public string Type { get; set; } = default!;

    /// <summary>Presence of the typed value on each occurrence. Collection multiplicity is expressed by type list/set, never by a separate many cardinality.</summary>
    [JsonPropertyName("cardinality")]
    [JsonRequired]
    public string Cardinality { get; set; } = default!;

    /// <summary>Ordered, deterministic normalization applied before typed evaluation.</summary>
    [JsonPropertyName("normalization")]
    [JsonRequired]
    public List<string> Normalization { get; set; } = default!;

    /// <summary>Data-handling classification carried with evidence and diagnostics.</summary>
    [JsonPropertyName("sensitivity")]
    [JsonRequired]
    public string Sensitivity { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("elementType")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> ElementType { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
