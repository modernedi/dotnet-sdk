// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Compact AK1/AK9 group selected for one transaction row; nested AK2 results are intentionally omitted.</summary>

public sealed class FunctionalAcknowledgmentGroupSummary
{
    /// <summary></summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Non-empty AK905 and later functional-group syntax error codes.</summary>
    [JsonPropertyName("errorCodes")]
    [JsonRequired]
    public List<string> ErrorCodes { get; set; } = default!;

    /// <summary>AK101 functional identifier code for the acknowledged group.</summary>
    [JsonPropertyName("functionalIdentifierCode")]
    [JsonRequired]
    public string? FunctionalIdentifierCode { get; set; } = default!;

    /// <summary>AK102 control number for the acknowledged functional group.</summary>
    [JsonPropertyName("functionalGroupControlNumber")]
    [JsonRequired]
    public string? FunctionalGroupControlNumber { get; set; } = default!;

    /// <summary>Raw AK103 functional-group version, or &#x60;null&#x60; when omitted.</summary>
    [JsonPropertyName("functionalGroupVersion")]
    [JsonRequired]
    public string? FunctionalGroupVersion { get; set; } = default!;

    /// <summary>Original AK901 acknowledgment code for this functional group.</summary>
    [JsonPropertyName("acknowledgmentCode")]
    [JsonRequired]
    public string? AcknowledgmentCode { get; set; } = default!;

    /// <summary>AK902 for this functional group.</summary>
    [JsonPropertyName("includedTransactionSets")]
    [JsonRequired]
    public int? IncludedTransactionSets { get; set; } = default!;

    /// <summary>AK903 for this functional group.</summary>
    [JsonPropertyName("receivedTransactionSets")]
    [JsonRequired]
    public int? ReceivedTransactionSets { get; set; } = default!;

    /// <summary>AK904 for this functional group; this count is distinct from an AK5 disposition.</summary>
    [JsonPropertyName("acceptedTransactionSets")]
    [JsonRequired]
    public int? AcceptedTransactionSets { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
