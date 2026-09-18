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

public sealed class X12SegmentValidationError
{
    /// <summary>Zero-based functional-group index within the parsed interchange.</summary>
    [JsonPropertyName("functionalGroupIndex")]
    [JsonRequired]
    public int FunctionalGroupIndex { get; set; } = default!;

    /// <summary>Zero-based transaction index within the containing functional group.</summary>
    [JsonPropertyName("transactionIndex")]
    [JsonRequired]
    public int TransactionIndex { get; set; } = default!;

    /// <summary>ST01 transaction-set identifier, such as &#x60;850&#x60; or &#x60;810&#x60;.</summary>
    [JsonPropertyName("transactionSetIdentifierCode")]
    [JsonRequired]
    public string TransactionSetIdentifierCode { get; set; } = default!;

    /// <summary>ST02 transaction control number used to correlate the finding with source X12.</summary>
    [JsonPropertyName("controlNumber")]
    [JsonRequired]
    public string ControlNumber { get; set; } = default!;

    /// <summary>X12 validator code for the transaction-level finding.</summary>
    [JsonPropertyName("code")]
    [JsonRequired]
    public string Code { get; set; } = default!;

    /// <summary>Human-readable explanation of the transaction-level finding.</summary>
    [JsonPropertyName("description")]
    [JsonRequired]
    public string Description { get; set; } = default!;

    /// <summary>Segment identifier, such as &#x60;BEG&#x60;, at the reported position.</summary>
    [JsonPropertyName("segmentId")]
    [JsonRequired]
    public string SegmentId { get; set; } = default!;

    /// <summary>One-based segment position within the transaction set.</summary>
    [JsonPropertyName("segmentPosition")]
    [JsonRequired]
    public int SegmentPosition { get; set; } = default!;

    /// <summary>Human-readable ST01 meaning, or &#x60;null&#x60; when the code is not in ModernEDI&#39;s reference catalog.</summary>
    [JsonPropertyName("transactionSetDescription")]
    [JsonRequired]
    public string? TransactionSetDescription { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
