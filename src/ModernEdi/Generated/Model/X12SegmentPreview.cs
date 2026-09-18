// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One parsed segment and its populated element values.</summary>

public sealed class X12SegmentPreview
{
    /// <summary>One-based segment position within the transaction.</summary>
    [JsonPropertyName("segmentPosition")]
    [JsonRequired]
    public int SegmentPosition { get; set; } = default!;

    /// <summary>X12 segment identifier, such as &#x60;BEG&#x60; or &#x60;N1&#x60;.</summary>
    [JsonPropertyName("segmentId")]
    [JsonRequired]
    public string SegmentId { get; set; } = default!;

    /// <summary>Human-readable segment name from the X12 reference catalog.</summary>
    [JsonPropertyName("segmentDescription")]
    [JsonRequired]
    public string SegmentDescription { get; set; } = default!;

    /// <summary>Loop-aware path of segment identifiers used to disambiguate repeated segments.</summary>
    [JsonPropertyName("segmentPath")]
    [JsonRequired]
    public List<string> SegmentPath { get; set; } = default!;

    /// <summary>Populated elements only; omitted/empty source elements are not included.</summary>
    [JsonPropertyName("elements")]
    [JsonRequired]
    public List<X12ElementPreview> Elements { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
