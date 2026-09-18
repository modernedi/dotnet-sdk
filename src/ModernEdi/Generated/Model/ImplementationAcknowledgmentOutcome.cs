// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Normalized X12 999 result. The aggregate status does not collapse the distinct AK1/AK9 group results or AK2/IK5 transaction-set results. &#x60;groups&#x60; preserves each AK101/AK102/AK103 identity and its AK9 rollup; &#x60;transactionSets&#x60; provides the same IK5 results as one attributable flat list. A 999 reports X12 syntax and relational validation. It does not indicate semantic or business acceptance, and it is not HIPAA implementation-guide certification. Only &#x60;accepted&#x60; is a clean automation completion. </summary>

public sealed class ImplementationAcknowledgmentOutcome
{
    /// <summary></summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Human-readable aggregate result suitable for a transaction timeline or status panel.</summary>
    [JsonPropertyName("summary")]
    [JsonRequired]
    public string Summary { get; set; } = default!;

    /// <summary>True when the 999 structure and required AK9 rollups were parsed successfully.</summary>
    [JsonPropertyName("parsed")]
    [JsonRequired]
    public bool Parsed { get; set; } = default!;

    /// <summary>Distinct non-empty syntax error codes reported by the 999.</summary>
    [JsonPropertyName("errorCodes")]
    [JsonRequired]
    public List<string> ErrorCodes { get; set; } = default!;

    /// <summary>Distinct AK1/AK9 implementation-group outcomes in source order.</summary>
    [JsonPropertyName("groups")]
    [JsonRequired]
    public List<ImplementationAcknowledgmentGroupOutcome> Groups { get; set; } = default!;

    /// <summary>Flattened AK2/IK5 transaction-set outcomes; each result repeats its parent AK101/AK102 identity for attribution.</summary>
    [JsonPropertyName("transactionSets")]
    [JsonRequired]
    public List<ImplementationAcknowledgmentTransactionSetOutcome> TransactionSets { get; set; } = default!;

    /// <summary>Aggregate acknowledgment code when one value represents the whole 999, or &#x60;null&#x60; for mixed or unavailable group results.</summary>
    [JsonPropertyName("acknowledgmentCode")]
    [JsonRequired]
    public string? AcknowledgmentCode { get; set; } = default!;

    /// <summary>Machine-readable reason when &#x60;status&#x60; is &#x60;unknown&#x60;.</summary>
    [JsonPropertyName("unknownReason")]
    [JsonRequired]
    public string? UnknownReason { get; set; } = default!;

    /// <summary>Aggregate count of transaction sets included across the acknowledged groups, when available.</summary>
    [JsonPropertyName("includedTransactionSets")]
    [JsonRequired]
    public int? IncludedTransactionSets { get; set; } = default!;

    /// <summary>Aggregate count of transaction sets received across the acknowledged groups, when available.</summary>
    [JsonPropertyName("receivedTransactionSets")]
    [JsonRequired]
    public int? ReceivedTransactionSets { get; set; } = default!;

    /// <summary>Aggregate count of received transaction sets accepted across the acknowledged groups, when available.</summary>
    [JsonPropertyName("acceptedTransactionSets")]
    [JsonRequired]
    public int? AcceptedTransactionSets { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
