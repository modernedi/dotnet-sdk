// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Current UTC-day message and transaction volume for one UTC hour.</summary>

public sealed class UsageHour
{
    /// <summary>Hour bucket label in &#x60;HH:00&#x60; form.</summary>
    [JsonPropertyName("hour")]
    [JsonRequired]
    public string Hour { get; set; } = default!;

    /// <summary>Distinct inbound AS2 messages accepted during this UTC hour.</summary>
    [JsonPropertyName("inboundMessages")]
    [JsonRequired]
    public int InboundMessages { get; set; } = default!;

    /// <summary>Distinct outbound AS2 messages accepted during this UTC hour.</summary>
    [JsonPropertyName("outboundMessages")]
    [JsonRequired]
    public int OutboundMessages { get; set; } = default!;

    /// <summary>Combined inbound and outbound accepted messages during this UTC hour.</summary>
    [JsonPropertyName("totalMessages")]
    [JsonRequired]
    public int TotalMessages { get; set; } = default!;

    /// <summary>Transaction-set rows recorded during this UTC hour; one AS2 message may contain multiple rows.</summary>
    [JsonPropertyName("transactionRows")]
    [JsonRequired]
    public int TransactionRows { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
