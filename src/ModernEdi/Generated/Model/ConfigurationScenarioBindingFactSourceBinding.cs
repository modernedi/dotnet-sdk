// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Binds one named fact declaration to one validated X12 Mapper expression. Fact names must be unique within a step.</summary>

public sealed class ConfigurationScenarioBindingFactSourceBinding
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("fact")]
    [JsonRequired]
    public string Fact { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("source")]
    [JsonRequired]
    public ConfigurationScenarioBindingFactSource Source { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
