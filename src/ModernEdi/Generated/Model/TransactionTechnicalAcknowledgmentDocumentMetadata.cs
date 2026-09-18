// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Send or receive direction and retained HTTP status for a technical acknowledgment.</summary>

public sealed class TransactionTechnicalAcknowledgmentDocumentMetadata
{
    /// <summary>True when ModernEDI sent the technical acknowledgment; false when it received one.</summary>
    [JsonPropertyName("sent")]
    [JsonRequired]
    public bool? Sent { get; set; } = default!;

    /// <summary>Retained downstream HTTP status, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("responseStatusCode")]
    [JsonRequired]
    public int? ResponseStatusCode { get; set; } = default!;

    /// <summary>Parsed TA1 result, or &#x60;null&#x60; when this artifact is only a retained HTTP response without TA1 X12.</summary>
    [JsonPropertyName("outcome")]
    [JsonRequired]
    public TechnicalAcknowledgmentOutcome? Outcome { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
