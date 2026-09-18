// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Portable desired state for one published mapping. Executable source is stored in the separately hashed &#x60;SOURCE&#x60; file named by the transform.</summary>

public sealed class ConfigurationMappingResourceDocument
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
    public ConfigurationResourceMetadata Metadata { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("spec")]
    [JsonRequired]
    public ConfigurationMappingSpec Spec { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
