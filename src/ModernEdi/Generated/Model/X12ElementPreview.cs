// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One populated X12 data element from a parsed segment.</summary>

public sealed class X12ElementPreview
{
    /// <summary>One-based element position within the segment.</summary>
    [JsonPropertyName("elementPosition")]
    [JsonRequired]
    public int ElementPosition { get; set; } = default!;

    /// <summary>X12 data-element definition number from the reference catalog.</summary>
    [JsonPropertyName("definition")]
    [JsonRequired]
    public string Definition { get; set; } = default!;

    /// <summary>Human-readable data-element name from the reference catalog.</summary>
    [JsonPropertyName("description")]
    [JsonRequired]
    public string Description { get; set; } = default!;

    /// <summary>Exact parsed source value; treat it as potentially sensitive business data.</summary>
    [JsonPropertyName("value")]
    [JsonRequired]
    public string Value { get; set; } = default!;

    /// <summary>Normalized data type from the X12 reference catalog for this populated element.</summary>
    [JsonPropertyName("dataType")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> DataType { get; set; }

    /// <summary>Number of trailing digits interpreted as fractional for a NUMERIC (Nn) element; omitted for every other data type.</summary>
    [JsonPropertyName("impliedDecimalDigits")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int> ImpliedDecimalDigits { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
