// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Single-character delimiters detected from the fixed-width ISA segment.</summary>

public sealed class X12SeparatorSummary
{
    /// <summary>Character separating simple elements within each segment.</summary>
    [JsonPropertyName("elementSeparator")]
    [JsonRequired]
    public string ElementSeparator { get; set; } = default!;

    /// <summary>Character separating components inside composite data elements.</summary>
    [JsonPropertyName("subElementSeparator")]
    [JsonRequired]
    public string SubElementSeparator { get; set; } = default!;

    /// <summary>Character terminating each X12 segment.</summary>
    [JsonPropertyName("segmentTerminator")]
    [JsonRequired]
    public string SegmentTerminator { get; set; } = default!;

    /// <summary>Repetition separator for versions that support repetitions, or &#x60;null&#x60; when unavailable.</summary>
    [JsonPropertyName("repetitionSeparator")]
    [JsonRequired]
    public string? RepetitionSeparator { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
