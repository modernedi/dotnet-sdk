// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Validation finding associated with one GS/GE functional group.</summary>

public sealed class X12FunctionalGroupValidationError
{
    /// <summary>Zero-based functional-group index within the parsed interchange.</summary>
    [JsonPropertyName("functionalGroupIndex")]
    [JsonRequired]
    public int FunctionalGroupIndex { get; set; } = default!;

    /// <summary>GS01 functional identifier code for the affected group.</summary>
    [JsonPropertyName("functionalIdentifierCode")]
    [JsonRequired]
    public string FunctionalIdentifierCode { get; set; } = default!;

    /// <summary>GS06 functional-group control number used to correlate the finding with source X12.</summary>
    [JsonPropertyName("controlNumber")]
    [JsonRequired]
    public string ControlNumber { get; set; } = default!;

    /// <summary>X12 validator code for the functional-group finding.</summary>
    [JsonPropertyName("code")]
    [JsonRequired]
    public string Code { get; set; } = default!;

    /// <summary>Human-readable explanation of the functional-group finding.</summary>
    [JsonPropertyName("description")]
    [JsonRequired]
    public string Description { get; set; } = default!;

    /// <summary>Human-readable GS01 code meaning, or &#x60;null&#x60; when the code is not in ModernEDI&#39;s reference catalog.</summary>
    [JsonPropertyName("functionalIdentifierDescription")]
    [JsonRequired]
    public string? FunctionalIdentifierDescription { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
