// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>X12 well-formedness and validation diagnostics produced from the submitted interchange.</summary>

public sealed class X12ValidationResult
{
    /// <summary>True only when parsing succeeded and no error- or failure-level X12 diagnostics were found.</summary>
    [JsonPropertyName("valid")]
    [JsonRequired]
    public bool Valid { get; set; } = default!;

    /// <summary>True when ModernEDI could parse an interchange envelope; a well-formed document may still be invalid.</summary>
    [JsonPropertyName("wellFormed")]
    [JsonRequired]
    public bool WellFormed { get; set; } = default!;

    /// <summary>Human-readable parser or validation errors that prevent the submitted interchange from being considered valid.</summary>
    [JsonPropertyName("errors")]
    [JsonRequired]
    public List<string> Errors { get; set; } = default!;

    /// <summary>Human-readable non-fatal findings that merit review but do not by themselves make &#x60;valid&#x60; false.</summary>
    [JsonPropertyName("warnings")]
    [JsonRequired]
    public List<string> Warnings { get; set; } = default!;

    /// <summary>Human-readable severe validation failures reported separately by the X12 validator.</summary>
    [JsonPropertyName("failures")]
    [JsonRequired]
    public List<string> Failures { get; set; } = default!;

    /// <summary>Structured findings attached to a GS/GE functional group, with zero-based group indexes for correlation.</summary>
    [JsonPropertyName("functionalGroupErrors")]
    [JsonRequired]
    public List<X12FunctionalGroupValidationError> FunctionalGroupErrors { get; set; } = default!;

    /// <summary>Structured findings attached to an ST/SE transaction set, with zero-based group and transaction indexes.</summary>
    [JsonPropertyName("transactionErrors")]
    [JsonRequired]
    public List<X12TransactionValidationError> TransactionErrors { get; set; } = default!;

    /// <summary>Structured segment-level X12 syntax findings, including the one-based position within the transaction.</summary>
    [JsonPropertyName("segmentErrors")]
    [JsonRequired]
    public List<X12SegmentValidationError> SegmentErrors { get; set; } = default!;

    /// <summary>Structured data-element findings identifying the segment, element, optional composite component, and rejected value.</summary>
    [JsonPropertyName("elementErrors")]
    [JsonRequired]
    public List<X12ElementValidationError> ElementErrors { get; set; } = default!;

    /// <summary>Interchange-level error disposition text, or &#x60;null&#x60; when the validator did not report one.</summary>
    [JsonPropertyName("dispositionError")]
    [JsonRequired]
    public string? DispositionError { get; set; } = default!;

    /// <summary>Interchange-level warning disposition text, or &#x60;null&#x60; when the validator did not report one.</summary>
    [JsonPropertyName("dispositionWarning")]
    [JsonRequired]
    public string? DispositionWarning { get; set; } = default!;

    /// <summary>Interchange-level failure disposition text, or &#x60;null&#x60; when the validator did not report one.</summary>
    [JsonPropertyName("dispositionFailure")]
    [JsonRequired]
    public string? DispositionFailure { get; set; } = default!;

    /// <summary>Parsed interchange summary with separators, groups, transactions, and segment previews; &#x60;null&#x60; when parsing did not produce an interchange.</summary>
    [JsonPropertyName("interchange")]
    [JsonRequired]
    public X12InterchangeSummary? Interchange { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
