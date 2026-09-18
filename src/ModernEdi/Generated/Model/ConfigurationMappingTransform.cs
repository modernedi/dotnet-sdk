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

public sealed class ConfigurationMappingTransform
{
    /// <summary>Executable mapping language.</summary>
    [JsonPropertyName("type")]
    [JsonRequired]
    public string Type { get; set; } = default!;

    /// <summary>Source-controlled transform filename shown in workspace and transaction provenance.</summary>
    [JsonPropertyName("fileName")]
    [JsonRequired]
    public string FileName { get; set; } = default!;

    /// <summary>Relative path of the corresponding &#x60;SOURCE&#x60; file in this bundle.</summary>
    [JsonPropertyName("sourcePath")]
    [JsonRequired]
    public string SourcePath { get; set; } = default!;

    /// <summary>SHA-256 of the exact UTF-8 mapping source bytes at &#x60;sourcePath&#x60;.</summary>
    [JsonPropertyName("sourceSha256")]
    [JsonRequired]
    public string SourceSha256 { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
