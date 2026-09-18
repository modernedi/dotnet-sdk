// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Immutable attribution captured when the configuration version was committed.</summary>

public sealed class ConfigurationChangedBy
{
    /// <summary>Kind of workspace actor that committed the version.</summary>
    [JsonPropertyName("type")]
    [JsonRequired]
    public string Type { get; set; } = default!;

    /// <summary>Human-readable actor label captured immutably at apply time.</summary>
    [JsonPropertyName("label")]
    [JsonRequired]
    public string Label { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
