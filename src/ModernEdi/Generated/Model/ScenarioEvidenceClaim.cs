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

public sealed class ScenarioEvidenceClaim
{
    /// <summary></summary>
    [JsonPropertyName("type")]
    [JsonRequired]
    public string Type { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("statement")]
    [JsonRequired]
    public string Statement { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("scope")]
    [JsonRequired]
    public string Scope { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
