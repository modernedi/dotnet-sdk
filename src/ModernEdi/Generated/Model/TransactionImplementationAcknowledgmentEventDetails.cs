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

public sealed class TransactionImplementationAcknowledgmentEventDetails
{
    /// <summary></summary>
    [JsonPropertyName("outcome")]
    [JsonRequired]
    public ImplementationAcknowledgmentOutcome Outcome { get; set; } = default!;

    /// <summary>AS2 Message-Id of the stored 999.</summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string? MessageId { get; set; } = default!;

    /// <summary>Delivery/persistence completion flag from the retained 999 record, or &#x60;null&#x60; when unavailable. It does not identify sender direction; use the transaction direction and timeline event type.</summary>
    [JsonPropertyName("sent")]
    [JsonRequired]
    public bool? Sent { get; set; } = default!;

    /// <summary>Whether the enclosing transaction was evaluated from its exact IK5 result, a unique AK9 group result, or the conservative whole-999 aggregate.</summary>
    [JsonPropertyName("evaluationScope")]
    [JsonRequired]
    public string? EvaluationScope { get; set; } = default!;

    /// <summary>Exact AK2/IK5 result selected for the enclosing transaction, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("transactionOutcome")]
    [JsonRequired]
    public ImplementationAcknowledgmentTransactionSetOutcome? TransactionOutcome { get; set; } = default!;

    /// <summary>Status selected by &#x60;evaluationScope&#x60;, or &#x60;null&#x60; when no outcome was attributable.</summary>
    [JsonPropertyName("evaluatedStatus")]
    [JsonRequired]
    public string? EvaluatedStatus { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
