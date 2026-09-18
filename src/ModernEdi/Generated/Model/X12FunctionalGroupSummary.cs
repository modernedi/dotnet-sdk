// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Parsed GS/GE group with its identity, control number, and transaction summaries.</summary>

public sealed class X12FunctionalGroupSummary
{
    /// <summary>Zero-based group index within the interchange.</summary>
    [JsonPropertyName("functionalGroupIndex")]
    [JsonRequired]
    public int FunctionalGroupIndex { get; set; } = default!;

    /// <summary>GS01 functional identifier code, such as &#x60;PO&#x60; or &#x60;IN&#x60;.</summary>
    [JsonPropertyName("functionalIdentifierCode")]
    [JsonRequired]
    public string FunctionalIdentifierCode { get; set; } = default!;

    /// <summary>GS06 functional-group control number.</summary>
    [JsonPropertyName("controlNumber")]
    [JsonRequired]
    public string ControlNumber { get; set; } = default!;

    /// <summary>X12 version declared by the functional-group header.</summary>
    [JsonPropertyName("x12Version")]
    [JsonRequired]
    public string X12Version { get; set; } = default!;

    /// <summary>Number of ST/SE transaction sets in this group.</summary>
    [JsonPropertyName("transactionCount")]
    [JsonRequired]
    public int TransactionCount { get; set; } = default!;

    /// <summary>Parsed transaction summaries in source order.</summary>
    [JsonPropertyName("transactions")]
    [JsonRequired]
    public List<X12TransactionSummary> Transactions { get; set; } = default!;

    /// <summary>Human-readable GS01 meaning, or &#x60;null&#x60; for an unknown code.</summary>
    [JsonPropertyName("functionalIdentifierDescription")]
    [JsonRequired]
    public string? FunctionalIdentifierDescription { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
