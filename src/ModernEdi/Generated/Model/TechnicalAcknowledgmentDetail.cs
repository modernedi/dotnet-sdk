// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Metadata for a stored X12 technical acknowledgment or downstream HTTP response. Fetch the indexed document for the body.</summary>

public sealed class TechnicalAcknowledgmentDetail
{
    /// <summary>True when ModernEDI sent the technical acknowledgment; false when it received one; &#x60;null&#x60; when unknown.</summary>
    [JsonPropertyName("sent")]
    [JsonRequired]
    public bool? Sent { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("timestamp")]
    [JsonRequired]
    public string? Timestamp { get; set; } = default!;

    /// <summary>Downstream HTTP response status code, or &#x60;null&#x60; when no raw transport response was retained.</summary>
    [JsonPropertyName("responseStatusCode")]
    [JsonRequired]
    public int? ResponseStatusCode { get; set; } = default!;

    /// <summary>Lowercase SHA-256 of the exact partner runtime configuration recorded for this transaction, receipt, or acknowledgment. It is &#x60;null&#x60; for legacy rows written before configuration stamping. Scenario verification accepts persisted evidence only when this value exactly matches the partner configuration frozen into the applied binding. </summary>
    [JsonPropertyName("partnerConfigurationSha256")]
    [JsonRequired]
    public string? PartnerConfigurationSha256 { get; set; } = default!;

    /// <summary>Parsed TA1 result, or &#x60;null&#x60; when the retained technical-acknowledgment record has no TA1 X12 body.</summary>
    [JsonPropertyName("outcome")]
    [JsonRequired]
    public TechnicalAcknowledgmentOutcome? Outcome { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
