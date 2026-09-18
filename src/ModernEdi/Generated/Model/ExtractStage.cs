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

public sealed class ExtractStage
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>Materialize declared semantic facts using binding/runtime-provided sources. Every declared fact must appear in exactly one extract stage.</summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("facts")]
    [JsonRequired]
    public List<string> Facts { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
