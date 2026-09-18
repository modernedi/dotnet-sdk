// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Selects optional source and mapping context included in &#x60;GET /v1/mapped-outputs&#x60; message objects and the webhook&#39;s nested &#x60;message&#x60; object. Every field defaults to &#x60;true&#x60;. Setting a field to &#x60;false&#x60; omits its corresponding message property; queue identifiers, receipt handles, payload, content type, purpose, and business key remain present. Webhook-envelope routing fields such as &#x60;tenantId&#x60; and &#x60;partnerId&#x60; also remain present. </summary>

public sealed class MappingDeliveredMetadata
{
    /// <summary>Include &#x60;partnerName&#x60; and tenant-scoped &#x60;partnerId&#x60; in the mapped-output message.</summary>
    [JsonPropertyName("partner")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> Partner { get; set; }

    /// <summary>Include the source transaction&#39;s persisted &#x60;transactionTimestamp&#x60;.</summary>
    [JsonPropertyName("transactionTimestamp")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> TransactionTimestamp { get; set; }

    /// <summary>Include &#x60;transactionSet&#x60; and the equivalent &#x60;edi.transactionGroupType&#x60; value.</summary>
    [JsonPropertyName("transactionSet")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> TransactionSet { get; set; }

    /// <summary>Include &#x60;controlNumbers.transaction&#x60; (X12 ST02).</summary>
    [JsonPropertyName("transactionControlNumber")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> TransactionControlNumber { get; set; }

    /// <summary>Include &#x60;controlNumbers.functionalGroup&#x60; (X12 GS06).</summary>
    [JsonPropertyName("functionalGroupControlNumber")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> FunctionalGroupControlNumber { get; set; }

    /// <summary>Include &#x60;edi.x12Version&#x60;, derived from the parsed interchange version.</summary>
    [JsonPropertyName("x12Version")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> X12Version { get; set; }

    /// <summary>Include &#x60;edi.functionalIdentifierCode&#x60; (X12 GS01).</summary>
    [JsonPropertyName("functionalIdentifierCode")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> FunctionalIdentifierCode { get; set; }

    /// <summary>Include &#x60;edi.segmentTerminator&#x60;.</summary>
    [JsonPropertyName("segmentTerminator")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> SegmentTerminator { get; set; }

    /// <summary>Include &#x60;mapping.fileSha256Hash&#x60;, the Base64-encoded SHA-256 hash of the map source that generated this output.</summary>
    [JsonPropertyName("mappingSourceHash")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> MappingSourceHash { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
