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

public sealed class ConfigurationPartnerSeparatorSet
{
    /// <summary></summary>
    [JsonPropertyName("elementSeparator")]
    [JsonRequired]
    public string ElementSeparator { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("subElementSeparator")]
    [JsonRequired]
    public string SubElementSeparator { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("segmentTerminator")]
    [JsonRequired]
    public string SegmentTerminator { get; set; } = default!;

    /// <summary>Repetition separator, or &#x60;null&#x60; when the selected X12 version does not use one.</summary>
    [JsonPropertyName("repetitionSeparator")]
    [JsonRequired]
    public string? RepetitionSeparator { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
