// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>X12 envelope and delimiter context captured for a transaction.</summary>

public sealed class TransactionEdiMetadata
{
    /// <summary>Numeric X12 implementation version, or &#x60;null&#x60; when it was not recorded.</summary>
    [JsonPropertyName("x12Version")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> X12Version { get; set; }

    /// <summary>GS01 functional identifier code, or &#x60;null&#x60; when it was not recorded.</summary>
    [JsonPropertyName("functionalIdentifierCode")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> FunctionalIdentifierCode { get; set; }

    /// <summary>ST01 transaction set identifier code recorded by the runtime.</summary>
    [JsonPropertyName("transactionGroupType")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> TransactionGroupType { get; set; }

    /// <summary>Single-character segment terminator detected from the interchange, or &#x60;null&#x60; when unavailable.</summary>
    [JsonPropertyName("segmentTerminator")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> SegmentTerminator { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
