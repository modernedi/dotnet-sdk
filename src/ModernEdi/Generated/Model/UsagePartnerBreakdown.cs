// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Current UTC-day message and transaction volume attributed to one partner.</summary>

public sealed class UsagePartnerBreakdown
{
    /// <summary>Partner display name captured on the counted transaction rows.</summary>
    [JsonPropertyName("partnerName")]
    [JsonRequired]
    public string PartnerName { get; set; } = default!;

    /// <summary>Distinct inbound AS2 messages attributed to this partner today.</summary>
    [JsonPropertyName("inboundMessages")]
    [JsonRequired]
    public int InboundMessages { get; set; } = default!;

    /// <summary>Distinct outbound AS2 messages attributed to this partner today.</summary>
    [JsonPropertyName("outboundMessages")]
    [JsonRequired]
    public int OutboundMessages { get; set; } = default!;

    /// <summary>Combined distinct inbound and outbound messages attributed to this partner today.</summary>
    [JsonPropertyName("totalMessages")]
    [JsonRequired]
    public int TotalMessages { get; set; } = default!;

    /// <summary>Transaction-set rows attributed to this partner today; one AS2 message may contain multiple rows.</summary>
    [JsonPropertyName("transactionRows")]
    [JsonRequired]
    public int TransactionRows { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
