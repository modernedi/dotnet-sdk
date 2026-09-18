// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary></summary>

public sealed class ConfigurationManifestResource
{
    /// <summary></summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary>Stable portable resource key used by other exported resources.</summary>
    [JsonPropertyName("key")]
    [JsonRequired]
    public string Key { get; set; } = default!;

    /// <summary>Path of the resource document in this bundle.</summary>
    [JsonPropertyName("path")]
    [JsonRequired]
    public string Path { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("contentSha256")]
    [JsonRequired]
    public string ContentSha256 { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
