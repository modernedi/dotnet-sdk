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

public sealed class X12ElementValidationError
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

    /// <summary>One-based element position within the affected segment.</summary>
    [JsonPropertyName("elementPosition")]
    [JsonRequired]
    public int ElementPosition { get; set; } = default!;

    /// <summary>X12 data-element definition number used to validate the value.</summary>
    [JsonPropertyName("elementDefinition")]
    [JsonRequired]
    public string ElementDefinition { get; set; } = default!;

    /// <summary>Exact submitted element value that failed validation; treat it as potentially sensitive business data.</summary>
    [JsonPropertyName("badValue")]
    [JsonRequired]
    public string BadValue { get; set; } = default!;

    /// <summary>Human-readable ST01 meaning, or &#x60;null&#x60; when the code is not in ModernEDI&#39;s reference catalog.</summary>
    [JsonPropertyName("transactionSetDescription")]
    [JsonRequired]
    public string? TransactionSetDescription { get; set; } = default!;

    /// <summary>One-based component position for a composite element, or &#x60;null&#x60; for a simple element.</summary>
    [JsonPropertyName("compositePosition")]
    [JsonRequired]
    public int? CompositePosition { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
