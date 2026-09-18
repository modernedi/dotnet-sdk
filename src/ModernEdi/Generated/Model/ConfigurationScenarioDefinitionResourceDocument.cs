// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Optional scenario configuration in the same reviewed bundle as connections, partners and maps. Retirement removes current configuration without deleting published revisions or run evidence.</summary>

public sealed class ConfigurationScenarioDefinitionResourceDocument
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    [JsonRequired]
    public string ApiVersion { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    [JsonRequired]
    public ConfigurationScenarioDefinitionResourceDocumentMetadata Metadata { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("spec")]
    [JsonRequired]
    public ConfigurationScenarioDefinitionResourceDocumentSpec Spec { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
