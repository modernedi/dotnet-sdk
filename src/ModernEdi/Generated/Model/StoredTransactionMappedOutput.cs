// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Metadata for a mapped output persisted on a transaction detail. Unlike a response-only replay output, it omits the body and always includes delivery applicability and current handoff state. Fetch its indexed document to obtain the payload. </summary>

public sealed class StoredTransactionMappedOutput
{
    /// <summary>Artifact identifier within the transaction response, such as &#x60;mapped-output-1&#x60;. This is not the managed-queue id and cannot be used with &#x60;/v1/mapped-outputs/{id}/ack&#x60;. Stored transaction details expose the queue correlation id separately as &#x60;delivery.outputId&#x60;. </summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>One-based display order of this output within the transaction response.</summary>
    [JsonPropertyName("sequenceNumber")]
    [JsonRequired]
    public int SequenceNumber { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("purpose")]
    [JsonRequired]
    public string Purpose { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("delivery")]
    [JsonRequired]
    public TransactionMappedOutputDelivery Delivery { get; set; } = default!;

    /// <summary>Media type of the corresponding mapped-output document body, or &#x60;null&#x60; for historical artifacts without recorded content type.</summary>
    [JsonPropertyName("contentType")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> ContentType { get; set; }

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("createdAt")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> CreatedAt { get; set; }

    /// <summary>Map-derived reconciliation identifier, or &#x60;null&#x60; when the map did not produce one.</summary>
    [JsonPropertyName("businessKey")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<TransactionBusinessKey?> BusinessKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mapping")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<TransactionMappedOutputMapping> Mapping { get; set; }

    /// <summary>Runtime routing metadata captured with the output; this is not the map&#39;s selectable delivered context.</summary>
    [JsonPropertyName("extraFields")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<Dictionary<string, string>> ExtraFields { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
