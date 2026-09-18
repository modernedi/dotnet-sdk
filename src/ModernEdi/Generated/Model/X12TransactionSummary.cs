// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Parsed ST/SE transaction identity and readable segment preview.</summary>

public sealed class X12TransactionSummary
{
    /// <summary>Zero-based index of the containing functional group.</summary>
    [JsonPropertyName("functionalGroupIndex")]
    [JsonRequired]
    public int FunctionalGroupIndex { get; set; } = default!;

    /// <summary>Zero-based transaction index within the group.</summary>
    [JsonPropertyName("transactionIndex")]
    [JsonRequired]
    public int TransactionIndex { get; set; } = default!;

    /// <summary>ST01 transaction-set identifier, such as &#x60;850&#x60; or &#x60;810&#x60;.</summary>
    [JsonPropertyName("transactionSetIdentifierCode")]
    [JsonRequired]
    public string TransactionSetIdentifierCode { get; set; } = default!;

    /// <summary>ST02 transaction control number.</summary>
    [JsonPropertyName("controlNumber")]
    [JsonRequired]
    public string ControlNumber { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("preview")]
    [JsonRequired]
    public X12TransactionPreview Preview { get; set; } = default!;

    /// <summary>Human-readable ST01 meaning, or &#x60;null&#x60; for an unknown code.</summary>
    [JsonPropertyName("transactionSetDescription")]
    [JsonRequired]
    public string? TransactionSetDescription { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
