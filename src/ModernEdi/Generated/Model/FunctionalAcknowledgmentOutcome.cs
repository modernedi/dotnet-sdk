// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Normalized whole-997 aggregate. The aggregate does not collapse the distinct AK1/AK9 group results or AK2/AK5 transaction-set results. &#x60;groups&#x60; preserves every AK101/AK102 identity, its AK901 disposition, its AK902-AK904 counts, and nested AK5 outcomes. A contradictory AK5/count rollup is reported as unknown rather than trusting an internally inconsistent 997. Whenever &#x60;status&#x60; is &#x60;unknown&#x60;, inspect &#x60;unknownReason&#x60; and fetch the &#x60;functional-ack-x12&#x60; document when the original body is needed. A false &#x60;parsed&#x60; value indicates a structural failure; an unsupported AK901, AK501, or syntax-error code can be structurally parsed while its status remains unknown. The &#x60;unsupported_acknowledgment_code&#x60; reason does not by itself prove that AK901 was unsupported. Only &#x60;accepted&#x60; is a clean automation completion. &#x60;accepted_with_errors&#x60; and &#x60;unknown&#x60; require review; &#x60;partially_accepted&#x60; and &#x60;rejected&#x60; are failure or rejection outcomes that require action. </summary>

public sealed class FunctionalAcknowledgmentOutcome
{
    /// <summary></summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Human-readable whole-997 aggregate result; transaction-scoped displays should use &#x60;evaluatedStatus&#x60; and the selected group or transaction outcome.</summary>
    [JsonPropertyName("summary")]
    [JsonRequired]
    public string Summary { get; set; } = default!;

    /// <summary>True when AK9 and all three AK902-AK904 counts were structurally valid.</summary>
    [JsonPropertyName("parsed")]
    [JsonRequired]
    public bool Parsed { get; set; } = default!;

    /// <summary>De-duplicated union of non-empty AK905 and later functional-group syntax error codes across every parsed group.</summary>
    [JsonPropertyName("errorCodes")]
    [JsonRequired]
    public List<string> ErrorCodes { get; set; } = default!;

    /// <summary>Distinct AK1/AK9 functional-group outcomes in source order; no sibling group is collapsed into another.</summary>
    [JsonPropertyName("groups")]
    [JsonRequired]
    public List<FunctionalAcknowledgmentGroupOutcome> Groups { get; set; } = default!;

    /// <summary>Transaction-set results from paired AK2 and AK5 segments. Each result repeats its parent AK101/AK102 identity so flattened results remain attributable when an interchange contains multiple 997 groups. </summary>
    [JsonPropertyName("transactionSets")]
    [JsonRequired]
    public List<FunctionalAcknowledgmentTransactionSetOutcome> TransactionSets { get; set; } = default!;

    /// <summary>Common original AK901 code when every parsed group has the same code; otherwise &#x60;null&#x60;.</summary>
    [JsonPropertyName("acknowledgmentCode")]
    [JsonRequired]
    public string? AcknowledgmentCode { get; set; } = default!;

    /// <summary>Machine-readable reason when &#x60;status&#x60; is &#x60;unknown&#x60;.</summary>
    [JsonPropertyName("unknownReason")]
    [JsonRequired]
    public string? UnknownReason { get; set; } = default!;

    /// <summary>Sum of AK902 across every parsed group, or &#x60;null&#x60; when any group count is unavailable or the sum overflows.</summary>
    [JsonPropertyName("includedTransactionSets")]
    [JsonRequired]
    public int? IncludedTransactionSets { get; set; } = default!;

    /// <summary>Sum of AK903 across every parsed group, or &#x60;null&#x60; when any group count is unavailable or the sum overflows.</summary>
    [JsonPropertyName("receivedTransactionSets")]
    [JsonRequired]
    public int? ReceivedTransactionSets { get; set; } = default!;

    /// <summary>Sum of AK904 across every parsed group, or &#x60;null&#x60; when any group count is unavailable or the sum overflows.</summary>
    [JsonPropertyName("acceptedTransactionSets")]
    [JsonRequired]
    public int? AcceptedTransactionSets { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
