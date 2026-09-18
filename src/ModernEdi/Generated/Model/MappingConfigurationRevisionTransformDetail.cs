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

public sealed class MappingConfigurationRevisionTransformDetail
{
    /// <summary>Transform runtime that compiled or interpreted this archived source.</summary>
    [JsonPropertyName("type")]
    [JsonRequired]
    public string Type { get; set; } = default!;

    /// <summary>Transform filename retained in this configuration revision.</summary>
    [JsonPropertyName("fileName")]
    [JsonRequired]
    public string FileName { get; set; } = default!;

    /// <summary>Complete immutable historical transform source, suitable for previewing or diffing against the current mapping source.</summary>
    [JsonPropertyName("source")]
    [JsonRequired]
    public string Source { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
