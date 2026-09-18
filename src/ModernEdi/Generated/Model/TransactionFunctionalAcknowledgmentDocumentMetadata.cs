// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Normalized X12 997 outcome and the evaluation selected for the enclosing transaction.</summary>

public sealed class TransactionFunctionalAcknowledgmentDocumentMetadata
{
    /// <summary></summary>
    [JsonPropertyName("outcome")]
    [JsonRequired]
    public FunctionalAcknowledgmentOutcome Outcome { get; set; } = default!;

    /// <summary>AS2 Message-Id of the stored 997.</summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string? MessageId { get; set; } = default!;

    /// <summary>Delivery/persistence completion flag from the retained 997 record, or &#x60;null&#x60; when unavailable. It does not identify sender direction; use the transaction direction and timeline event type.</summary>
    [JsonPropertyName("sent")]
    [JsonRequired]
    public bool? Sent { get; set; } = default!;

    /// <summary>Whether the enclosing transaction was evaluated from its exact AK2/AK5 result, uniquely matched AK1/AK9 group, or whole-997 ambiguity fallback.</summary>
    [JsonPropertyName("evaluationScope")]
    [JsonRequired]
    public string? EvaluationScope { get; set; } = default!;

    /// <summary>Exact AK1/AK9 group selected for the enclosing transaction, or &#x60;null&#x60; when no group was uniquely attributable.</summary>
    [JsonPropertyName("groupOutcome")]
    [JsonRequired]
    public FunctionalAcknowledgmentGroupOutcome? GroupOutcome { get; set; } = default!;

    /// <summary>Exact AK2/AK5 result selected for the enclosing transaction, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("transactionOutcome")]
    [JsonRequired]
    public FunctionalAcknowledgmentTransactionSetOutcome? TransactionOutcome { get; set; } = default!;

    /// <summary>Status selected by &#x60;evaluationScope&#x60;, or &#x60;null&#x60; when no outcome was attributable.</summary>
    [JsonPropertyName("evaluatedStatus")]
    [JsonRequired]
    public string? EvaluatedStatus { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
