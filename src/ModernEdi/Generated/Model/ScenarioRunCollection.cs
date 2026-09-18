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

public sealed class ScenarioRunCollection
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    [JsonRequired]
    public string ApiVersion { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("runs")]
    [JsonRequired]
    public List<ScenarioRunSummary> Runs { get; set; } = default!;

    /// <summary>Opaque tenant-bound keyset cursor for the next page, or null when history is exhausted.</summary>
    [JsonPropertyName("nextCursor")]
    [JsonRequired]
    public string? NextCursor { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
