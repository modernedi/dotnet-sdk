// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Active transaction counts by independently applicable attention reason.</summary>

public sealed class TransactionAttentionSummaryReasonCounts
{
    /// <summary>Transactions with one or more unresolved mapping attempts.</summary>
    [JsonPropertyName("mappingFailure")]
    [JsonRequired]
    public int MappingFailure { get; set; } = default!;

    /// <summary>Transactions with a received 997 that was not cleanly accepted.</summary>
    [JsonPropertyName("functionalAckIssue")]
    [JsonRequired]
    public int FunctionalAckIssue { get; set; } = default!;

    /// <summary>Transactions with a received 999 whose selected IK5 or AK9 result was not cleanly accepted.</summary>
    [JsonPropertyName("implementationAckIssue")]
    [JsonRequired]
    public int ImplementationAckIssue { get; set; } = default!;

    /// <summary>Eligible outbound transactions with neither a 997 nor a 999 received by their response deadline.</summary>
    [JsonPropertyName("x12AckOverdue")]
    [JsonRequired]
    public int X12AckOverdue { get; set; } = default!;

    /// <summary>Outbound transactions whose requested TA1 rejected the interchange, reported errors, or could not be classified.</summary>
    [JsonPropertyName("technicalAckIssue")]
    [JsonRequired]
    public int TechnicalAckIssue { get; set; } = default!;

    /// <summary>Outbound transactions whose ISA14 requested a TA1 that was not received by its response deadline.</summary>
    [JsonPropertyName("technicalAckOverdue")]
    [JsonRequired]
    public int TechnicalAckOverdue { get; set; } = default!;

    /// <summary>Outbound transactions whose AS2 MDN is overdue or was received with a warning, rejection, validation failure, or content-MIC mismatch.</summary>
    [JsonPropertyName("as2MdnAttention")]
    [JsonRequired]
    public int As2MdnAttention { get; set; } = default!;

    /// <summary>Transactions with at least one managed output that was not collected within the 15-minute pickup grace period.</summary>
    [JsonPropertyName("mappedOutputNotCollected")]
    [JsonRequired]
    public int MappedOutputNotCollected { get; set; } = default!;

    /// <summary>Transactions with an expired unacknowledged output lease or an unacknowledged redelivery.</summary>
    [JsonPropertyName("mappedOutputAckOverdue")]
    [JsonRequired]
    public int MappedOutputAckOverdue { get; set; } = default!;

    /// <summary>Transactions placed on an active operator watchlist independently of automated failure signals.</summary>
    [JsonPropertyName("watchlist")]
    [JsonRequired]
    public int Watchlist { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
