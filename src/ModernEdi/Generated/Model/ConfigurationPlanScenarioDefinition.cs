// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Portable release identity of the scenario definition used by an affected binding.</summary>

public sealed class ConfigurationPlanScenarioDefinition
{
    /// <summary></summary>
    [JsonPropertyName("namespace")]
    [JsonRequired]
    public string Namespace { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("key")]
    [JsonRequired]
    public string Key { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("version")]
    [JsonRequired]
    public string VarVersion { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
