// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>AS2 message disposition notification (MDN) metadata without its report body. For an outbound document ModernEDI normally requests an asynchronous signed receipt. While that receipt is outstanding this object has &#x60;status: pending&#x60;; it becomes &#x60;overdue&#x60; after the platform response deadline, which defaults to one hour after send. A received receipt is accepted as &#x60;processed&#x60; only after its Original-Message-ID, requested MIC algorithm, returned MIC, and disposition are validated. Review &#x60;as2_mdn_attention&#x60; before resending; ModernEDI does not resend automatically because an invalid or missing receipt does not prove the partner failed to process the document. </summary>

public sealed class TransactionMdn
{
    /// <summary></summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Message-ID of the MDN itself. Null while an asynchronous receipt is still pending or overdue.</summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string? MessageId { get; set; } = default!;

    /// <summary>Raw AS2 Disposition field returned by the partner. Use normalized &#x60;status&#x60; for automation and retain this value for partner troubleshooting.</summary>
    [JsonPropertyName("disposition")]
    [JsonRequired]
    public string? Disposition { get; set; } = default!;

    /// <summary>True when ModernEDI sent this MDN for an inbound document; false when it received or is awaiting the partner&#39;s MDN for an outbound document.</summary>
    [JsonPropertyName("sent")]
    [JsonRequired]
    public bool? Sent { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("timestamp")]
    [JsonRequired]
    public string? Timestamp { get; set; } = default!;

    /// <summary>True when the receipt was requested or delivered through the asynchronous Receipt-Delivery-Option callback rather than the original HTTP response.</summary>
    [JsonPropertyName("asynchronous")]
    [JsonRequired]
    public bool? Asynchronous { get; set; } = default!;

    /// <summary>Whether the partner&#39;s Received-content-MIC digest and algorithm matched the canonical content ModernEDI sent. Null while pending or when comparison was not possible.</summary>
    [JsonPropertyName("micMatched")]
    [JsonRequired]
    public bool? MicMatched { get; set; } = default!;

    /// <summary>Partner-supplied Received-content-MIC value, including its algorithm token when present.</summary>
    [JsonPropertyName("receivedContentMic")]
    [JsonRequired]
    public string? ReceivedContentMic { get; set; } = default!;

    /// <summary>Base64 digest ModernEDI calculated over the exact canonical MIME content sent to the partner.</summary>
    [JsonPropertyName("expectedContentMic")]
    [JsonRequired]
    public string? ExpectedContentMic { get; set; } = default!;

    /// <summary>Receipt MIC algorithm ModernEDI requested from the partner; currently &#x60;sha1&#x60; for compatibility with legacy partner connections.</summary>
    [JsonPropertyName("expectedMicAlgorithm")]
    [JsonRequired]
    public string? ExpectedMicAlgorithm { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("expectedBy")]
    [JsonRequired]
    public string? ExpectedBy { get; set; } = default!;

    /// <summary>Specific validation or partner-disposition problem that caused &#x60;warning&#x60;, &#x60;rejected&#x60;, &#x60;invalid&#x60;, or &#x60;mic_mismatch&#x60;.</summary>
    [JsonPropertyName("validationError")]
    [JsonRequired]
    public string? ValidationError { get; set; } = default!;

    /// <summary>Lowercase SHA-256 of the exact partner runtime configuration recorded for this transaction, receipt, or acknowledgment. It is &#x60;null&#x60; for legacy rows written before configuration stamping. Scenario verification accepts persisted evidence only when this value exactly matches the partner configuration frozen into the applied binding. </summary>
    [JsonPropertyName("partnerConfigurationSha256")]
    [JsonRequired]
    public string? PartnerConfigurationSha256 { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
