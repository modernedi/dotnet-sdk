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

public sealed class MappingRuntimeHealthTotals
{
    /// <summary>Unresolved failures across all retained mapping revisions and unmatched requests.</summary>
    [JsonPropertyName("failed")]
    [JsonRequired]
    public int Failed { get; set; } = default!;

    /// <summary>Unresolved failures produced by currently published mapping revisions.</summary>
    [JsonPropertyName("currentRevisionFailed")]
    [JsonRequired]
    public int CurrentRevisionFailed { get; set; } = default!;

    /// <summary>Unresolved failures for which no published mapping was resolved.</summary>
    [JsonPropertyName("unmappedFailed")]
    [JsonRequired]
    public int UnmappedFailed { get; set; } = default!;

    /// <summary>Failures marked resolved by a later successful equivalent attempt.</summary>
    [JsonPropertyName("recovered")]
    [JsonRequired]
    public int Recovered { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
