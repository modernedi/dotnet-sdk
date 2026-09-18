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

public sealed class FunctionalAcknowledgmentGroupOutcome
{
    /// <summary></summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Non-empty AK905 and later functional-group syntax error codes.</summary>
    [JsonPropertyName("errorCodes")]
    [JsonRequired]
    public List<string> ErrorCodes { get; set; } = default!;

    /// <summary>AK2/AK5 outcomes belonging to this exact AK1/AK9 group. Empty when AK2 was omitted.</summary>
    [JsonPropertyName("transactionSets")]
    [JsonRequired]
    public List<FunctionalAcknowledgmentTransactionSetOutcome> TransactionSets { get; set; } = default!;

    /// <summary>AK101 functional identifier code for the acknowledged group, such as &#x60;PO&#x60; or &#x60;IN&#x60;.</summary>
    [JsonPropertyName("functionalIdentifierCode")]
    [JsonRequired]
    public string? FunctionalIdentifierCode { get; set; } = default!;

    /// <summary>AK102 control number for the acknowledged functional group.</summary>
    [JsonPropertyName("functionalGroupControlNumber")]
    [JsonRequired]
    public string? FunctionalGroupControlNumber { get; set; } = default!;

    /// <summary>Raw AK103 functional-group version, or &#x60;null&#x60; when the sender omitted it; ModernEDI does not infer an implementation guide.</summary>
    [JsonPropertyName("functionalGroupVersion")]
    [JsonRequired]
    public string? FunctionalGroupVersion { get; set; } = default!;

    /// <summary>Original AK901 acknowledgment code for this functional group, when available.</summary>
    [JsonPropertyName("acknowledgmentCode")]
    [JsonRequired]
    public string? AcknowledgmentCode { get; set; } = default!;

    /// <summary>AK902, the number of transaction sets included in this functional group.</summary>
    [JsonPropertyName("includedTransactionSets")]
    [JsonRequired]
    public int? IncludedTransactionSets { get; set; } = default!;

    /// <summary>AK903, the number of transaction sets received in this functional group.</summary>
    [JsonPropertyName("receivedTransactionSets")]
    [JsonRequired]
    public int? ReceivedTransactionSets { get; set; } = default!;

    /// <summary>AK904, the number of received transaction sets accepted in this functional group. This count is not an AK5 transaction disposition.</summary>
    [JsonPropertyName("acceptedTransactionSets")]
    [JsonRequired]
    public int? AcceptedTransactionSets { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
