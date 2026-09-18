// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Immutable identity of a published definition. The identity tuple is namespace, key, and version; contentSha256 is computed when the definition is published.</summary>

public sealed class ConfigurationScenarioDefinitionMetadata
{
    /// <summary>A lowercase, DNS-like ownership namespace.</summary>
    [JsonPropertyName("namespace")]
    [JsonRequired]
    public string Namespace { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("key")]
    [JsonRequired]
    public string Key { get; set; } = default!;

    /// <summary>A trim-exact artifact version with no control characters. This versions a published definition; it is separate from apiVersion.</summary>
    [JsonPropertyName("version")]
    [JsonRequired]
    public string VarVersion { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
