// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Application-facing output produced by an inbound mapping.</summary>

public sealed class TransactionMappedOutputDocument
{
    /// <summary>Stable transaction-local artifact id derived from the mapped-output sequence number.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>Selects the mapped-output renderer and map-provenance metadata shape.</summary>
    [JsonPropertyName("type")]
    [JsonRequired]
    public string Type { get; set; } = default!;

    /// <summary>Customer-readable artifact name suitable for a transaction document list.</summary>
    [JsonPropertyName("label")]
    [JsonRequired]
    public string Label { get; set; } = default!;

    /// <summary>Media type describing how to parse or display &#x60;content&#x60;.</summary>
    [JsonPropertyName("contentType")]
    [JsonRequired]
    public string ContentType { get; set; } = default!;

    /// <summary>Representation of &#x60;content&#x60;; currently all public transaction documents are returned as text.</summary>
    [JsonPropertyName("encoding")]
    [JsonRequired]
    public string Encoding { get; set; } = default!;

    /// <summary>Length of the retained text artifact; use it as display context and to decide whether to fetch, not as a checksum.</summary>
    [JsonPropertyName("contentLength")]
    [JsonRequired]
    public int ContentLength { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    [JsonRequired]
    public TransactionMappedOutputDocumentMetadata Metadata { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("timestamp")]
    [JsonRequired]
    public string? Timestamp { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
