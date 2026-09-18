// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Direction and normalized outcome fields for one sent or received TA1 timeline event.</summary>

public sealed class TransactionTechnicalAcknowledgmentEventDetails
{
    /// <summary>True when ModernEDI sent the TA1; false when it received one.</summary>
    [JsonPropertyName("sent")]
    [JsonRequired]
    public bool? Sent { get; set; } = default!;

    /// <summary>Retained downstream HTTP status, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("responseStatusCode")]
    [JsonRequired]
    public int? ResponseStatusCode { get; set; } = default!;

    /// <summary>Normalized TA104 outcome, or &#x60;null&#x60; when no TA1 payload was available to parse.</summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string? Status { get; set; } = default!;

    /// <summary>Raw TA104 code, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("acknowledgmentCode")]
    [JsonRequired]
    public string? AcknowledgmentCode { get; set; } = default!;

    /// <summary>Raw TA105 code, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("errorCode")]
    [JsonRequired]
    public string? ErrorCode { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
