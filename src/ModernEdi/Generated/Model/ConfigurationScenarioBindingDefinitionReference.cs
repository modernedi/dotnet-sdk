// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Exact identity and canonical content hash returned by Publish or the scenario catalog. Apply fails closed if any part differs.</summary>

public sealed class ConfigurationScenarioBindingDefinitionReference
{
    /// <summary>Lowercase namespace of the published ScenarioDefinition.</summary>
    [JsonPropertyName("namespace")]
    [JsonRequired]
    public string Namespace { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("key")]
    [JsonRequired]
    public string Key { get; set; } = default!;

    /// <summary>Exact published definition version.</summary>
    [JsonPropertyName("version")]
    [JsonRequired]
    public string VarVersion { get; set; } = default!;

    /// <summary>Lowercase SHA-256 digest of the canonical published definition.</summary>
    [JsonPropertyName("contentSha256")]
    [JsonRequired]
    public string ContentSha256 { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
