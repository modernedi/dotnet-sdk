// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Successful response containing one immutable historical mapping-configuration revision and its complete stored configuration.</summary>

public sealed class MappingConfigurationRevisionResponse
{
    /// <summary>Always &#x60;true&#x60;; failures use the documented error response instead.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("revision")]
    [JsonRequired]
    public MappingConfigurationRevisionDetail Revision { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("mappingConfiguration")]
    [JsonRequired]
    public MappingConfigurationSnapshot MappingConfiguration { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
