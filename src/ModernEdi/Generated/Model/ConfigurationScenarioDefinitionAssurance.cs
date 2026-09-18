// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Operational evidence required for each occurrence of this step. Duplicate requirement types are rejected by the server.</summary>

public sealed class ConfigurationScenarioDefinitionAssurance
{
    /// <summary></summary>
    [JsonPropertyName("requirements")]
    [JsonRequired]
    public List<ConfigurationScenarioDefinitionAssuranceRequirement> Requirements { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
