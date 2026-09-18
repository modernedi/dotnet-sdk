// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Metadata and normalized outcome for a stored X12 997. Fetch the indexed functional-acknowledgment document for the X12 body.</summary>

public sealed class FunctionalAcknowledgmentDetail
{
    /// <summary></summary>
    [JsonPropertyName("outcome")]
    [JsonRequired]
    public FunctionalAcknowledgmentOutcome Outcome { get; set; } = default!;

    /// <summary>AS2 Message-Id of the stored 997, or &#x60;null&#x60; when only partial acknowledgment data was retained.</summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string? MessageId { get; set; } = default!;

    /// <summary>Delivery/persistence completion flag from the retained 997 record. True means its acknowledgment lifecycle completed, false means it did not, and &#x60;null&#x60; means the state is unavailable. This is not sender direction; use the transaction direction and timeline event type to determine whether ModernEDI sent or received the 997.</summary>
    [JsonPropertyName("sent")]
    [JsonRequired]
    public bool? Sent { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("timestamp")]
    [JsonRequired]
    public string? Timestamp { get; set; } = default!;

    /// <summary>Lowercase SHA-256 of the exact partner runtime configuration recorded for this transaction, receipt, or acknowledgment. It is &#x60;null&#x60; for legacy rows written before configuration stamping. Scenario verification accepts persisted evidence only when this value exactly matches the partner configuration frozen into the applied binding. </summary>
    [JsonPropertyName("partnerConfigurationSha256")]
    [JsonRequired]
    public string? PartnerConfigurationSha256 { get; set; } = default!;

    /// <summary>AS2 receipt assurance state, or &#x60;null&#x60; when no MDN applies or was recorded.</summary>
    [JsonPropertyName("mdn")]
    [JsonRequired]
    public TransactionMdn? Mdn { get; set; } = default!;

    /// <summary>Whether this transaction was evaluated against its exact AK2/AK5 result, its uniquely matched AK1/AK9 group, or the whole-997 aggregate because no group was uniquely attributable.</summary>
    [JsonPropertyName("evaluationScope")]
    [JsonRequired]
    public string? EvaluationScope { get; set; } = default!;

    /// <summary>Unique AK1/AK9 group outcome attributable to this transaction, or &#x60;null&#x60; when group identity is absent or ambiguous.</summary>
    [JsonPropertyName("groupOutcome")]
    [JsonRequired]
    public FunctionalAcknowledgmentGroupOutcome? GroupOutcome { get; set; } = default!;

    /// <summary>Exact AK2/AK5 outcome attributable to this transaction, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("transactionOutcome")]
    [JsonRequired]
    public FunctionalAcknowledgmentTransactionSetOutcome? TransactionOutcome { get; set; } = default!;

    /// <summary>Status selected for this transaction at &#x60;evaluationScope&#x60;, or &#x60;null&#x60; when no evaluation was available.</summary>
    [JsonPropertyName("evaluatedStatus")]
    [JsonRequired]
    public string? EvaluatedStatus { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
