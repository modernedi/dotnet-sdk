// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Transaction-local X12 text and parsed segment/element values for inspection.</summary>

public sealed class X12TransactionPreview
{
    /// <summary>Complete ST-through-SE X12 text for this transaction using the detected delimiters.</summary>
    [JsonPropertyName("x12")]
    [JsonRequired]
    public string X12 { get; set; } = default!;

    /// <summary>Number of parsed segments included in &#x60;segments&#x60;.</summary>
    [JsonPropertyName("segmentCount")]
    [JsonRequired]
    public int SegmentCount { get; set; } = default!;

    /// <summary>Parsed segments in source order with loop-aware paths.</summary>
    [JsonPropertyName("segments")]
    [JsonRequired]
    public List<X12SegmentPreview> Segments { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
