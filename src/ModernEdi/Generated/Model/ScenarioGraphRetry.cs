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

public sealed class ScenarioGraphRetry
{
    /// <summary></summary>
    [JsonPropertyName("mode")]
    [JsonRequired]
    public string Mode { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("reason")]
    [JsonRequired]
    public string Reason { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("requiresApiKey")]
    [JsonRequired]
    public bool RequiresApiKey { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
