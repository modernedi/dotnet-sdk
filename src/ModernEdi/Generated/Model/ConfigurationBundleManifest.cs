// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Portable desired-state manifest stored at &#x60;modernedi.json&#x60;. It inventories resources and all desired files but intentionally excludes the manifest itself and &#x60;_state/snapshot.json&#x60;.</summary>

public sealed class ConfigurationBundleManifest
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    [JsonRequired]
    public string ApiVersion { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary>Exported resources sorted lexicographically by their resource-document path.</summary>
    [JsonPropertyName("resources")]
    [JsonRequired]
    public List<ConfigurationManifestResource> Resources { get; set; } = default!;

    /// <summary>Resource and mapping-source files sorted lexicographically by path. Manifest and state files are excluded.</summary>
    [JsonPropertyName("files")]
    [JsonRequired]
    public List<ConfigurationManifestFile> Files { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
