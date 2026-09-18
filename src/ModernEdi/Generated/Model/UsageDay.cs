// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Accepted AS2 message counts for one UTC calendar date.</summary>

public sealed class UsageDay
{
    /// <summary>UTC calendar date for these counts.</summary>
    [JsonPropertyName("date")]
    [JsonRequired]
    public DateOnly Date { get; set; } = default!;

    /// <summary>Distinct inbound AS2 messages accepted on this date.</summary>
    [JsonPropertyName("inboundMessages")]
    [JsonRequired]
    public int InboundMessages { get; set; } = default!;

    /// <summary>Distinct outbound AS2 messages accepted on this date.</summary>
    [JsonPropertyName("outboundMessages")]
    [JsonRequired]
    public int OutboundMessages { get; set; } = default!;

    /// <summary>Combined inbound and outbound accepted AS2 messages for this date.</summary>
    [JsonPropertyName("totalMessages")]
    [JsonRequired]
    public int TotalMessages { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
