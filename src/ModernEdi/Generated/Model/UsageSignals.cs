// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Current-day workload-shape indicators derived from accepted transaction rows and message ids.</summary>

public sealed class UsageSignals
{
    /// <summary>Total transaction-set rows recorded today; may exceed message count when interchanges are batched.</summary>
    [JsonPropertyName("transactionRowsToday")]
    [JsonRequired]
    public int TransactionRowsToday { get; set; } = default!;

    /// <summary>Distinct AS2 message ids that contained more than one transaction row today.</summary>
    [JsonPropertyName("multiTransactionMessageIdsToday")]
    [JsonRequired]
    public int MultiTransactionMessageIdsToday { get; set; } = default!;

    /// <summary>Distinct AS2 message count in &#x60;busiestHour&#x60;, or zero when there is no busiest hour.</summary>
    [JsonPropertyName("busiestHourMessages")]
    [JsonRequired]
    public int BusiestHourMessages { get; set; } = default!;

    /// <summary>Distinct AS2 message count for &#x60;topPartnerName&#x60;, or zero when no top partner exists.</summary>
    [JsonPropertyName("topPartnerMessages")]
    [JsonRequired]
    public int TopPartnerMessages { get; set; } = default!;

    /// <summary>UTC &#x60;HH:00&#x60; bucket with the most messages today, or &#x60;null&#x60; when no messages were recorded.</summary>
    [JsonPropertyName("busiestHour")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> BusiestHour { get; set; }

    /// <summary>Partner with the most messages today, or &#x60;null&#x60; when no partner-attributed messages were recorded.</summary>
    [JsonPropertyName("topPartnerName")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> TopPartnerName { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
