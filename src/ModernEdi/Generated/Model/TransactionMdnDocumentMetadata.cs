// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Full receipt-assurance metadata for the original transaction&#39;s MDN report.</summary>

public sealed class TransactionMdnDocumentMetadata
{
    /// <summary>Normalized receipt-assurance outcome; only &#x60;processed&#x60; is a clean final success.</summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Message-ID of the MDN itself, or &#x60;null&#x60; while an asynchronous receipt is pending.</summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string? MessageId { get; set; } = default!;

    /// <summary>Raw AS2 Disposition value returned by the partner.</summary>
    [JsonPropertyName("disposition")]
    [JsonRequired]
    public string? Disposition { get; set; } = default!;

    /// <summary>Whether the receipt used the asynchronous Receipt-Delivery-Option callback.</summary>
    [JsonPropertyName("asynchronous")]
    [JsonRequired]
    public bool? Asynchronous { get; set; } = default!;

    /// <summary>Whether the returned MIC matched the canonical content ModernEDI sent.</summary>
    [JsonPropertyName("micMatched")]
    [JsonRequired]
    public bool? MicMatched { get; set; } = default!;

    /// <summary>Partner-supplied Received-content-MIC value.</summary>
    [JsonPropertyName("receivedContentMic")]
    [JsonRequired]
    public string? ReceivedContentMic { get; set; } = default!;

    /// <summary>Digest ModernEDI calculated over the sent canonical MIME content.</summary>
    [JsonPropertyName("expectedContentMic")]
    [JsonRequired]
    public string? ExpectedContentMic { get; set; } = default!;

    /// <summary>MIC algorithm ModernEDI requested.</summary>
    [JsonPropertyName("expectedMicAlgorithm")]
    [JsonRequired]
    public string? ExpectedMicAlgorithm { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("expectedBy")]
    [JsonRequired]
    public string? ExpectedBy { get; set; } = default!;

    /// <summary>Specific receipt validation or disposition problem, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("validationError")]
    [JsonRequired]
    public string? ValidationError { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
