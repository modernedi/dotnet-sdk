// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Metadata-first operator aggregate spanning mapping provenance, queue custody, normalized acknowledgments, a document index, and compact related-reply summaries.</summary>

public sealed class TransactionDetail
{
    /// <summary>True when the transaction has an active operational watch, an unresolved mapping failure, or a 997 or 999 acknowledgment outcome other than &#x60;accepted&#x60;, when neither acknowledgment was received for an eligible outbound transaction by &#x60;x12AcknowledgmentExpectedBy&#x60;, when a requested TA1 rejected the interchange, reported errors, could not be classified, or was not received by &#x60;technicalAckExpectedBy&#x60;, when a managed output remained uncollected beyond its 15-minute pickup grace period, or when a delivered output was not acknowledged before its lease expired or was redelivered. A newly ready output inside the grace period and an active first lease are normal handoff progress and do not set this signal by themselves. </summary>
    [JsonPropertyName("needsAttention")]
    [JsonRequired]
    public bool NeedsAttention { get; set; } = default!;

    /// <summary>Active machine-readable reasons behind &#x60;needsAttention&#x60;.</summary>
    [JsonPropertyName("attentionReasons")]
    [JsonRequired]
    public List<TransactionAttentionReason> AttentionReasons { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("mappingStatus")]
    [JsonRequired]
    public TransactionMappingStatus MappingStatus { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("summary")]
    [JsonRequired]
    public TransactionSummary Summary { get; set; } = default!;

    /// <summary>Metadata, mapping provenance, and managed-delivery state for inbound mapped outputs. Payload bodies are available through the document endpoints. Outbound reply transactions return an empty array.</summary>
    [JsonPropertyName("mappedOutputs")]
    [JsonRequired]
    public List<StoredTransactionMappedOutput> MappedOutputs { get; set; } = default!;

    /// <summary>Metadata index of retained source, mapped-output, acknowledgment, and HTTP-response documents.</summary>
    [JsonPropertyName("documents")]
    [JsonRequired]
    public List<TransactionDocumentMetadata> Documents { get; set; } = default!;

    /// <summary>Chronological operational timeline derived from persisted transaction artifacts.</summary>
    [JsonPropertyName("events")]
    [JsonRequired]
    public List<TransactionEvent> Events { get; set; } = default!;

    /// <summary>Compact summaries of outbound replies linked to this inbound transaction. Fetch a selected reply&#39;s detail on demand.</summary>
    [JsonPropertyName("relatedTransactions")]
    [JsonRequired]
    public List<TransactionSummary> RelatedTransactions { get; set; } = default!;

    /// <summary>Normalized AS2 receipt metadata without the report body. Fetch &#x60;mdn-report&#x60; from the document endpoint to inspect that body.</summary>
    [JsonPropertyName("mdn")]
    [JsonRequired]
    public TransactionMdn? Mdn { get; set; } = default!;

    /// <summary>Normalized X12 functional-acknowledgment metadata without the X12 body. Fetch &#x60;functional-ack-x12&#x60; from the document endpoint to inspect it.</summary>
    [JsonPropertyName("functionalAck")]
    [JsonRequired]
    public FunctionalAcknowledgmentDetail? FunctionalAck { get; set; } = default!;

    /// <summary>Normalized X12 999 implementation-acknowledgment metadata without the X12 body. Fetch &#x60;implementation-ack-x12&#x60; from the document endpoint to inspect it.</summary>
    [JsonPropertyName("implementationAck")]
    [JsonRequired]
    public ImplementationAcknowledgmentDetail? ImplementationAck { get; set; } = default!;

    /// <summary>Technical-acknowledgment transport metadata without X12 or HTTP response bodies, or &#x60;null&#x60; when none was recorded. Fetch the indexed document to inspect a body.</summary>
    [JsonPropertyName("technicalAck")]
    [JsonRequired]
    public TechnicalAcknowledgmentDetail? TechnicalAck { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
