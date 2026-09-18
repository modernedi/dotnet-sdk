// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Stable list-level transaction identity, partner context, acknowledgment state, and operator-attention projection.</summary>

public sealed class TransactionSummary
{
    /// <summary>Convenience id formatted as &#x60;&lt;messageId&gt;/&lt;transactionKey&gt;&#x60;.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary>Stable operator-inbox signal. True when an unexpired watchlist entry is active, a mapping failure remains unresolved, or the 997 outcome selected by &#x60;functionalAckEvaluationScope&#x60; or the 999 outcome selected by &#x60;implementationAckEvaluationScope&#x60; is present and is not &#x60;accepted&#x60;, or neither a 997 nor a 999 was received for an eligible outbound transaction by &#x60;x12AcknowledgmentExpectedBy&#x60;, or a requested TA1 rejected the interchange, reported errors, could not be classified, or was not received by &#x60;technicalAckExpectedBy&#x60;, or when a managed output remained uncollected beyond its 15-minute pickup grace period, or when a delivered output was not acknowledged before its lease expired or was redelivered. A newly ready output inside the grace period and an active first lease are normal handoff progress and do not set this signal by themselves. </summary>
    [JsonPropertyName("needsAttention")]
    [JsonRequired]
    public bool NeedsAttention { get; set; } = default!;

    /// <summary>Active machine-readable reasons behind &#x60;needsAttention&#x60;.</summary>
    [JsonPropertyName("attentionReasons")]
    [JsonRequired]
    public List<TransactionAttentionReason> AttentionReasons { get; set; } = default!;

    /// <summary>True while an active watchlist entry exists for this transaction. Entries created through the Integration API remain active until &#x60;DELETE /v1/integration/transactions/{messageId}/{transactionKey}/watch&#x60; removes them. An active watch is also represented by the &#x60;watchlist&#x60; attention reason. </summary>
    [JsonPropertyName("onWatchlist")]
    [JsonRequired]
    public bool OnWatchlist { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("mappingStatus")]
    [JsonRequired]
    public TransactionMappingStatusSummary MappingStatus { get; set; } = default!;

    /// <summary>AS2 Message-Id for this transaction.</summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string MessageId { get; set; } = default!;

    /// <summary>Transaction identifier within the AS2 message, usually &#x60;GS06#ST02&#x60;.</summary>
    [JsonPropertyName("transactionKey")]
    [JsonRequired]
    public string TransactionKey { get; set; } = default!;

    /// <summary>Direction across the ModernEDI boundary: inbound from the partner or outbound to the partner.</summary>
    [JsonPropertyName("direction")]
    [JsonRequired]
    public string Direction { get; set; } = default!;

    /// <summary>Partner name captured for display; use &#x60;partnerId&#x60; for stable automation across renames.</summary>
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

    /// <summary>True when the outbound ISA14 requested a TA1 interchange acknowledgment. False for inbound traffic, outbound interchanges that did not request TA1, and legacy rows that predate this persisted signal.</summary>
    [JsonPropertyName("technicalAckRequested")]
    [JsonRequired]
    public bool TechnicalAckRequested { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("technicalAckStatus")]
    [JsonRequired]
    public string TechnicalAckStatus { get; set; } = default!;

    /// <summary>Compact 997 status selected for this transaction. ModernEDI uses a uniquely matched AK2/AK5 outcome when possible, otherwise the uniquely matched AK1/AK9 functional-group outcome, and only then the conservative whole-997 aggregate. Null means no attributable 997 status is currently available. Use &#x60;x12_ack_overdue&#x60; for an actionable missing X12 acknowledgment. </summary>
    [JsonPropertyName("functionalAckStatus")]
    [JsonRequired]
    public string? FunctionalAckStatus { get; set; } = default!;

    /// <summary>Compact 999 status selected for this transaction. ModernEDI uses a uniquely matched AK2/IK5 result when possible. Group fallback conservatively reduces the matching AK9 status with every nested IK5 status, and whole-999 fallback reduces the aggregate with every flattened IK5 status. A non-accepted primary fallback remains authoritative. An accepted primary with any nested &#x60;unknown&#x60; becomes &#x60;unknown&#x60;; an accepted primary with any definitive non-clean nested result becomes &#x60;accepted_with_errors&#x60;, not the sibling&#39;s rejection or partial disposition. This prevents a raw accepted fallback from hiding a non-clean result or falsely assigning a sibling&#39;s disposition to this row, without changing the raw AK9 or IK5 fields. Null means no attributable 999 status is currently available. </summary>
    [JsonPropertyName("implementationAckStatus")]
    [JsonRequired]
    public string? ImplementationAckStatus { get; set; } = default!;

    /// <summary>Compact normalized AS2 receipt-assurance status. Null means no MDN status applies or the asynchronous status projection has not indexed this row yet. Check &#x60;attentionSummary.freshness&#x60; on list responses before interpreting a null during projection bootstrap. </summary>
    [JsonPropertyName("mdnStatus")]
    [JsonRequired]
    public string? MdnStatus { get; set; } = default!;

    /// <summary>Present on outbound replies and points back to the inbound AS2 message id.</summary>
    [JsonPropertyName("replyToMessageId")]
    [JsonRequired]
    public string? ReplyToMessageId { get; set; } = default!;

    /// <summary>Exact inbound transaction key for an outbound reply, or &#x60;null&#x60; for a transaction that is not a reply. Related-transaction queries attach the reply only to this transaction inside &#x60;replyToMessageId&#x60;. </summary>
    [JsonPropertyName("replyToTransactionKey")]
    [JsonRequired]
    public string? ReplyToTransactionKey { get; set; } = default!;

    /// <summary>Persisted tenant-scoped partner id that authorizes this transaction and remains stable across partner renames.</summary>
    [JsonPropertyName("partnerId")]
    [JsonRequired]
    public int? PartnerId { get; set; } = default!;

    /// <summary>Lowercase SHA-256 of the exact partner runtime configuration recorded for this transaction, receipt, or acknowledgment. It is &#x60;null&#x60; for legacy rows written before configuration stamping. Scenario verification accepts persisted evidence only when this value exactly matches the partner configuration frozen into the applied binding. </summary>
    [JsonPropertyName("partnerConfigurationSha256")]
    [JsonRequired]
    public string? PartnerConfigurationSha256 { get; set; } = default!;

    /// <summary>Business key recorded on this transaction. Inbound keys come from the incoming map. Outbound keys are present when &#x60;/send&#x60;, &#x60;/reply&#x60;, or &#x60;/carbonCopy&#x60; supplied &#x60;businessKey&#x60; in the JSON request envelope; otherwise this is &#x60;null&#x60;. </summary>
    [JsonPropertyName("businessKey")]
    [JsonRequired]
    public TransactionBusinessKey? BusinessKey { get; set; } = default!;

    /// <summary>Compact normalized whole-997 aggregate. Distinct AK1/AK9 groups are intentionally omitted from list responses; use &#x60;functionalAckGroupOutcome&#x60; for this row&#39;s selected compact group and transaction detail or the &#x60;functional-ack-x12&#x60; document metadata for every full group. A null value means no compact outcome was available, normally because no 997 is stored; list enrichment is fail-soft, so callers should use transaction detail before treating null as proof that no acknowledgment exists. Do not use the aggregate status as this row&#39;s status; use &#x60;functionalAckStatus&#x60; and &#x60;functionalAckEvaluationScope&#x60;. </summary>
    [JsonPropertyName("functionalAckOutcome")]
    [JsonRequired]
    public FunctionalAcknowledgmentSummary? FunctionalAckOutcome { get; set; } = default!;

    /// <summary>Exact AK2/AK5 result matched to this row by GS06/AK102 and ST02/AK202, with a leading-zero-insensitive control-number fallback only when it yields one unique match. Null means no unique transaction-set result could be attributed. </summary>
    [JsonPropertyName("functionalAckTransactionOutcome")]
    [JsonRequired]
    public FunctionalAcknowledgmentTransactionSetOutcome? FunctionalAckTransactionOutcome { get; set; } = default!;

    /// <summary>Exact AK1/AK9 group matched to this row by GS06/AK102 and GS01/AK101. Exact control-number identity is preferred; a leading-zero-insensitive fallback is used only when it yields one unique group. Null means no group was uniquely attributable. This row-level projection omits the group&#39;s nested AK2 results to keep list, reply, and event payloads bounded; fetch transaction detail for the complete group tree. </summary>
    [JsonPropertyName("functionalAckGroupOutcome")]
    [JsonRequired]
    public FunctionalAcknowledgmentGroupSummary? FunctionalAckGroupOutcome { get; set; } = default!;

    /// <summary>Outcome level ModernEDI used for &#x60;functional_ack_issue&#x60;. &#x60;transaction_set&#x60; uses a unique AK2/AK5 disposition while retaining the matching AK9 group separately. &#x60;functional_group&#x60; is used when AK2 is omitted or no unique transaction result exists. &#x60;functional_acknowledgment&#x60; is the conservative whole-997 fallback only when no AK1 group can be matched uniquely. Null means no 997 outcome was available. </summary>
    [JsonPropertyName("functionalAckEvaluationScope")]
    [JsonRequired]
    public string? FunctionalAckEvaluationScope { get; set; } = default!;

    /// <summary>Compact normalized whole-999 result plus distinct AK1/AK9 group outcomes. A null value normally means no 999 is stored. This remains the acknowledgment-wide context even when ModernEDI can evaluate this row against a narrower group or transaction result. </summary>
    [JsonPropertyName("implementationAckOutcome")]
    [JsonRequired]
    public ImplementationAcknowledgmentSummary? ImplementationAckOutcome { get; set; } = default!;

    /// <summary>Exact AK2/IK5 result matched uniquely to this row by the functional-group and transaction-set identifiers. Null means no unique transaction-set result could be attributed. </summary>
    [JsonPropertyName("implementationAckTransactionOutcome")]
    [JsonRequired]
    public ImplementationAcknowledgmentTransactionSetOutcome? ImplementationAckTransactionOutcome { get; set; } = default!;

    /// <summary>Outcome level ModernEDI used for &#x60;implementation_ack_issue&#x60;. &#x60;transaction_set&#x60; selects a unique AK2/IK5 result; &#x60;implementation_group&#x60; selects a unique AK1/AK9 group and conservatively reduces it with nested IK5 statuses; &#x60;implementation_acknowledgment&#x60; conservatively reduces the aggregate with all flattened IK5 statuses when no unique group is attributable. Null means no 999 outcome was available. </summary>
    [JsonPropertyName("implementationAckEvaluationScope")]
    [JsonRequired]
    public string? ImplementationAckEvaluationScope { get; set; } = default!;

    /// <summary>Deadline used to classify a still-missing partner X12 acknowledgment for an eligible outbound business transaction. Outbound 997 and 999 acknowledgment documents are excluded. Receipt of either a correlated 997 or 999 satisfies the deadline. This is null when no deadline applies. Use the &#x60;x12_ack_overdue&#x60; attention reason, not this timestamp alone, as the authoritative active overdue signal. ModernEDI does not automatically resend the original X12 when the deadline passes. </summary>
    [JsonPropertyName("x12AcknowledgmentExpectedBy")]
    [JsonRequired]
    public string? X12AcknowledgmentExpectedBy { get; set; } = default!;

    /// <summary>Deadline for a TA1 explicitly requested by outbound ISA14, or &#x60;null&#x60; when none was requested. Use &#x60;technical_ack_overdue&#x60; as the authoritative active overdue signal. ModernEDI does not automatically resend when this deadline passes.</summary>
    [JsonPropertyName("technicalAckExpectedBy")]
    [JsonRequired]
    public string? TechnicalAckExpectedBy { get; set; } = default!;

    /// <summary>Parsed TA1 outcome correlated by the original AS2 message id, or &#x60;null&#x60; while a requested TA1 is still pending or when none was requested.</summary>
    [JsonPropertyName("technicalAckOutcome")]
    [JsonRequired]
    public TechnicalAcknowledgmentOutcome? TechnicalAckOutcome { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
