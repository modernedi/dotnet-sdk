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

public sealed class ConfigurationContextResponseApiKey
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public long Id { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("label")]
    [JsonRequired]
    public string Label { get; set; } = default!;

    /// <summary>Current grants, sorted lexicographically. No write grant is implied by a read grant.</summary>
    [JsonPropertyName("scopes")]
    [JsonRequired]
    public List<string> Scopes { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
