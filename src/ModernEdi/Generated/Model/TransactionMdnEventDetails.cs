// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Safe normalized AS2 receipt diagnostics used by MDN timeline events.</summary>

public sealed class TransactionMdnEventDetails
{
    /// <summary>Normalized receipt-assurance state that determines the event type.</summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Message-ID of the MDN itself.</summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string? MessageId { get; set; } = default!;

    /// <summary>Raw AS2 Disposition value.</summary>
    [JsonPropertyName("disposition")]
    [JsonRequired]
    public string? Disposition { get; set; } = default!;

    /// <summary>Whether the receipt used the asynchronous Receipt-Delivery-Option callback.</summary>
    [JsonPropertyName("asynchronous")]
    [JsonRequired]
    public bool? Asynchronous { get; set; } = default!;

    /// <summary>Whether the returned MIC matched the sent canonical content.</summary>
    [JsonPropertyName("micMatched")]
    [JsonRequired]
    public bool? MicMatched { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("expectedBy")]
    [JsonRequired]
    public string? ExpectedBy { get; set; } = default!;

    /// <summary>Receipt validation or disposition problem, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("validationError")]
    [JsonRequired]
    public string? ValidationError { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
