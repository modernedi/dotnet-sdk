// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Parsed ISA/IEA envelope and its functional groups, transactions, separators, and readable previews.</summary>

public sealed class X12InterchangeSummary
{
    /// <summary>X12 implementation version resolved from the interchange and functional-group headers.</summary>
    [JsonPropertyName("x12Version")]
    [JsonRequired]
    public string X12Version { get; set; } = default!;

    /// <summary>ISA13 interchange control number from the submitted document.</summary>
    [JsonPropertyName("controlNumber")]
    [JsonRequired]
    public string ControlNumber { get; set; } = default!;

    /// <summary>Whether the interchange is an X12 technical acknowledgment document.</summary>
    [JsonPropertyName("technicalAcknowledgment")]
    [JsonRequired]
    public bool TechnicalAcknowledgment { get; set; } = default!;

    /// <summary>Whether the interchange is an X12 997 functional acknowledgment.</summary>
    [JsonPropertyName("functionalAcknowledgment")]
    [JsonRequired]
    public bool FunctionalAcknowledgment { get; set; } = default!;

    /// <summary>Whether the interchange is an X12 999 implementation acknowledgment.</summary>
    [JsonPropertyName("implementationAcknowledgment")]
    [JsonRequired]
    public bool ImplementationAcknowledgment { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("separators")]
    [JsonRequired]
    public X12SeparatorSummary Separators { get; set; } = default!;

    /// <summary>Number of parsed GS/GE functional groups in the interchange.</summary>
    [JsonPropertyName("functionalGroupCount")]
    [JsonRequired]
    public int FunctionalGroupCount { get; set; } = default!;

    /// <summary>Total number of parsed ST/SE transaction sets across all groups.</summary>
    [JsonPropertyName("transactionCount")]
    [JsonRequired]
    public int TransactionCount { get; set; } = default!;

    /// <summary>Parsed functional groups in source order.</summary>
    [JsonPropertyName("functionalGroups")]
    [JsonRequired]
    public List<X12FunctionalGroupSummary> FunctionalGroups { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
