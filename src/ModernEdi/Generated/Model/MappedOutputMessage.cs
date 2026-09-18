// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One mapped application document leased from ModernEDI&#39;s managed output queue.</summary>

public sealed class MappedOutputMessage
{
    /// <summary>Stable id for this generated output version, used when marking the message received. A later durable regeneration can produce a new id for the same &#x60;messageId&#x60; and &#x60;mappedOutputKey&#x60;. </summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>Token from the latest poll response, required when marking the message received.</summary>
    [JsonPropertyName("receiptHandle")]
    [JsonRequired]
    public string ReceiptHandle { get; set; } = default!;

    /// <summary>Number of pull or webhook delivery leases issued for this generated output version.</summary>
    [JsonPropertyName("deliveryCount")]
    [JsonRequired]
    public int DeliveryCount { get; set; } = default!;

    /// <summary>Original inbound AS2 message id. Use this value as &#x60;originalMessageId&#x60; when sending a reply with &#x60;/v1/as2/reply&#x60;. </summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string MessageId { get; set; } = default!;

    /// <summary>Transaction identifier within the AS2 message, usually &#x60;GS06#ST02&#x60;.</summary>
    [JsonPropertyName("transactionKey")]
    [JsonRequired]
    public string TransactionKey { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary>Unique mapped-output key inside the transaction.</summary>
    [JsonPropertyName("mappedOutputKey")]
    [JsonRequired]
    public string MappedOutputKey { get; set; } = default!;

    /// <summary>Zero-based output order when one source transaction produces multiple mapped documents.</summary>
    [JsonPropertyName("sequenceNumber")]
    [JsonRequired]
    public int SequenceNumber { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("purpose")]
    [JsonRequired]
    public string Purpose { get; set; } = default!;

    /// <summary>UTC instant when ModernEDI may return this message again if it has not been marked received.</summary>
    [JsonPropertyName("leasedUntil")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> LeasedUntil { get; set; }

    /// <summary>Partner name. Omitted when &#x60;deliveredMetadata.partner&#x60; is &#x60;false&#x60;.</summary>
    [JsonPropertyName("partnerName")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> PartnerName { get; set; }

    /// <summary>Persisted tenant-scoped partner id. Omitted when &#x60;deliveredMetadata.partner&#x60; is &#x60;false&#x60;.</summary>
    [JsonPropertyName("partnerId")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int> PartnerId { get; set; }

    /// <summary>Source transaction timestamp. Omitted when &#x60;deliveredMetadata.transactionTimestamp&#x60; is &#x60;false&#x60;.</summary>
    [JsonPropertyName("transactionTimestamp")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> TransactionTimestamp { get; set; }

    /// <summary>Transaction-set code and description. Omitted when &#x60;deliveredMetadata.transactionSet&#x60; is &#x60;false&#x60;.</summary>
    [JsonPropertyName("transactionSet")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<TransactionSet> TransactionSet { get; set; }

    /// <summary>X12 transaction and functional-group control numbers. Individual properties are omitted according to &#x60;deliveredMetadata.transactionControlNumber&#x60; and &#x60;deliveredMetadata.functionalGroupControlNumber&#x60;; the object is omitted when both are &#x60;false&#x60;. </summary>
    [JsonPropertyName("controlNumbers")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<TransactionControlNumbers> ControlNumbers { get; set; }

    /// <summary>Optional X12 context controlled by &#x60;deliveredMetadata.transactionSet&#x60;, &#x60;x12Version&#x60;, &#x60;functionalIdentifierCode&#x60;, and &#x60;segmentTerminator&#x60;. The object is omitted when all four are &#x60;false&#x60;. </summary>
    [JsonPropertyName("edi")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<TransactionEdiMetadata> Edi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mapping")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<MappedOutputMapping> Mapping { get; set; }

    /// <summary>Media type for &#x60;payload&#x60;, such as &#x60;application/json&#x60; or &#x60;application/xml&#x60;.</summary>
    [JsonPropertyName("contentType")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> ContentType { get; set; }

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("createdAt")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> CreatedAt { get; set; }

    /// <summary>Map-derived business identifier for customer reconciliation, or &#x60;null&#x60; when the map did not produce one.</summary>
    [JsonPropertyName("businessKey")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<TransactionBusinessKey?> BusinessKey { get; set; }

    /// <summary>Runtime routing metadata recorded with the generated output, such as &#x60;{\&quot;destination\&quot;:\&quot;managedQueue\&quot;}&#x60;. This is not the customer-selectable context; use the mapping&#39;s &#x60;deliveredMetadata&#x60; flags for that. </summary>
    [JsonPropertyName("extraFields")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<Dictionary<string, string>> ExtraFields { get; set; }

    /// <summary>Mapped document body. Parse according to &#x60;contentType&#x60;.</summary>
    [JsonPropertyName("payload")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> Payload { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
