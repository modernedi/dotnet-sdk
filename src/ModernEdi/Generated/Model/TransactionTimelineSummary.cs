// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Stable transaction identity used inside transaction and reply timeline events. It intentionally omits the current attention and mapping projections; refetch transaction detail for authoritative current state. </summary>

public sealed class TransactionTimelineSummary
{
    /// <summary>Convenience id formatted as &#x60;&lt;messageId&gt;/&lt;transactionKey&gt;&#x60;.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary>AS2 Message-Id that identifies the transaction for detail and correlation requests.</summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string MessageId { get; set; } = default!;

    /// <summary>Transaction identifier within the AS2 message, usually &#x60;GS06#ST02&#x60;.</summary>
    [JsonPropertyName("transactionKey")]
    [JsonRequired]
    public string TransactionKey { get; set; } = default!;

    /// <summary>Direction across the ModernEDI boundary at the time this timeline snapshot was created.</summary>
    [JsonPropertyName("direction")]
    [JsonRequired]
    public string Direction { get; set; } = default!;

    /// <summary>Partner name captured at processing time.</summary>
    [JsonPropertyName("partnerName")]
    [JsonRequired]
    public string PartnerName { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;.</summary>
    [JsonPropertyName("timestamp")]
    [JsonRequired]
    public string Timestamp { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("transactionSet")]
    [JsonRequired]
    public TransactionSet TransactionSet { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("controlNumbers")]
    [JsonRequired]
    public TransactionControlNumbers ControlNumbers { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("edi")]
    [JsonRequired]
    public TransactionEdiMetadata Edi { get; set; } = default!;

    /// <summary>Whether outbound ISA14 requested a TA1 for this timeline snapshot.</summary>
    [JsonPropertyName("technicalAckRequested")]
    [JsonRequired]
    public bool TechnicalAckRequested { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("technicalAckStatus")]
    [JsonRequired]
    public string TechnicalAckStatus { get; set; } = default!;

    /// <summary>Source inbound message for an outbound reply, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("replyToMessageId")]
    [JsonRequired]
    public string? ReplyToMessageId { get; set; } = default!;

    /// <summary>Exact source transaction for an outbound reply, or &#x60;null&#x60; for a non-reply.</summary>
    [JsonPropertyName("replyToTransactionKey")]
    [JsonRequired]
    public string? ReplyToTransactionKey { get; set; } = default!;

    /// <summary>Stable tenant-scoped partner id.</summary>
    [JsonPropertyName("partnerId")]
    [JsonRequired]
    public int? PartnerId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("businessKey")]
    [JsonRequired]
    public TransactionBusinessKey? BusinessKey { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("functionalAckOutcome")]
    [JsonRequired]
    public FunctionalAcknowledgmentSummary? FunctionalAckOutcome { get; set; } = default!;

    /// <summary>Exact AK2/AK5 outcome uniquely attributable to this transaction, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("functionalAckTransactionOutcome")]
    [JsonRequired]
    public FunctionalAcknowledgmentTransactionSetOutcome? FunctionalAckTransactionOutcome { get; set; } = default!;

    /// <summary>Compact AK1/AK9 group outcome uniquely attributable to this transaction, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("functionalAckGroupOutcome")]
    [JsonRequired]
    public FunctionalAcknowledgmentGroupSummary? FunctionalAckGroupOutcome { get; set; } = default!;

    /// <summary>Whether operator status used the exact transaction-set result, the matching group, or the whole-997 ambiguity fallback.</summary>
    [JsonPropertyName("functionalAckEvaluationScope")]
    [JsonRequired]
    public string? FunctionalAckEvaluationScope { get; set; } = default!;

    /// <summary>Compact aggregate and group-level 999 context, or &#x60;null&#x60; when no 999 was attributable.</summary>
    [JsonPropertyName("implementationAckOutcome")]
    [JsonRequired]
    public ImplementationAcknowledgmentSummary? ImplementationAckOutcome { get; set; } = default!;

    /// <summary>Exact AK2/IK5 outcome uniquely attributable to this transaction, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("implementationAckTransactionOutcome")]
    [JsonRequired]
    public ImplementationAcknowledgmentTransactionSetOutcome? ImplementationAckTransactionOutcome { get; set; } = default!;

    /// <summary>Whether operator status used the exact IK5 result, a unique AK9 group result, or the conservative whole-999 aggregate.</summary>
    [JsonPropertyName("implementationAckEvaluationScope")]
    [JsonRequired]
    public string? ImplementationAckEvaluationScope { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("x12AcknowledgmentExpectedBy")]
    [JsonRequired]
    public string? X12AcknowledgmentExpectedBy { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("technicalAckExpectedBy")]
    [JsonRequired]
    public string? TechnicalAckExpectedBy { get; set; } = default!;

    /// <summary>Parsed TA1 outcome correlated to the interchange represented by this timeline snapshot, or &#x60;null&#x60; while no TA1 is available. Use &#x60;technicalAckStatus&#x60; and the &#x60;technical_ack_overdue&#x60; attention reason to distinguish not requested, pending, and overdue states; a null outcome alone is not evidence that the partner accepted the interchange. </summary>
    [JsonPropertyName("technicalAckOutcome")]
    [JsonRequired]
    public TechnicalAcknowledgmentOutcome? TechnicalAckOutcome { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
