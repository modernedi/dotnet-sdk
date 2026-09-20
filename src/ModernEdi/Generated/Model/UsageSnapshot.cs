// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Workspace AS2-message usage across Production and Test traffic and self-service plan enforcement state, measured in UTC. Both traffic environments share one daily quota. Transaction-based breakdowns count a message ID once per traffic environment, even if the same ID exists in both.</summary>

public sealed class UsageSnapshot
{
    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;.</summary>
    [JsonPropertyName("asOf")]
    [JsonRequired]
    public string AsOf { get; set; } = default!;

    /// <summary>Time zone defining daily and hourly buckets; currently always &#x60;UTC&#x60;.</summary>
    [JsonPropertyName("timeZone")]
    [JsonRequired]
    public string VarTimeZone { get; set; } = default!;

    /// <summary>AS2 messages attempted across Production and Test traffic since 00:00 UTC, including accepted and rejected messages. Quota status and usage notifications use this count.</summary>
    [JsonPropertyName("attemptedMessagesToday")]
    [JsonRequired]
    public int AttemptedMessagesToday { get; set; } = default!;

    /// <summary>AS2 messages accepted for processing since 00:00 UTC.</summary>
    [JsonPropertyName("acceptedMessagesToday")]
    [JsonRequired]
    public int AcceptedMessagesToday { get; set; } = default!;

    /// <summary>AS2 messages rejected by quota enforcement since 00:00 UTC.</summary>
    [JsonPropertyName("rejectedMessagesToday")]
    [JsonRequired]
    public int RejectedMessagesToday { get; set; } = default!;

    /// <summary>True when attempted usage has crossed the rejection threshold and new messages are being rejected.</summary>
    [JsonPropertyName("rejectionActive")]
    [JsonRequired]
    public bool RejectionActive { get; set; } = default!;

    /// <summary>True when this workspace has no configured daily AS2 message limit.</summary>
    [JsonPropertyName("unlimited")]
    [JsonRequired]
    public bool Unlimited { get; set; } = default!;

    /// <summary>Stable state: &#x60;ok&#x60;, &#x60;approaching_limit&#x60;, &#x60;over_limit&#x60;, &#x60;rejection_active&#x60;, or &#x60;unlimited&#x60;.</summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Machine-readable quota behavior, currently &#x60;reject_after_safety_threshold&#x60; or &#x60;not_configured&#x60;.</summary>
    [JsonPropertyName("enforcementMode")]
    [JsonRequired]
    public string EnforcementMode { get; set; } = default!;

    /// <summary>Customer-readable explanation of the workspace&#39;s current quota and safety-threshold policy.</summary>
    [JsonPropertyName("policy")]
    [JsonRequired]
    public string Policy { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("today")]
    [JsonRequired]
    public UsageDay Today { get; set; } = default!;

    /// <summary>Daily accepted-message totals for the retained usage window, ordered by date.</summary>
    [JsonPropertyName("dailyUsage")]
    [JsonRequired]
    public List<UsageDay> DailyUsage { get; set; } = default!;

    /// <summary>Current UTC-day accepted messages and transaction rows grouped by partner.</summary>
    [JsonPropertyName("todayByPartner")]
    [JsonRequired]
    public List<UsagePartnerBreakdown> TodayByPartner { get; set; } = default!;

    /// <summary>Current UTC-day accepted messages and transaction rows grouped into UTC hour buckets.</summary>
    [JsonPropertyName("todayByHour")]
    [JsonRequired]
    public List<UsageHour> TodayByHour { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("signals")]
    [JsonRequired]
    public UsageSignals Signals { get; set; } = default!;

    /// <summary>Current billing plan code, or &#x60;null&#x60; when billing metadata is unavailable.</summary>
    [JsonPropertyName("planCode")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> PlanCode { get; set; }

    /// <summary>Included AS2 messages per UTC day, or &#x60;null&#x60; for an unlimited plan.</summary>
    [JsonPropertyName("dailyLimit")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int?> DailyLimit { get; set; }

    /// <summary>Attempted-message count that changes &#x60;status&#x60; to &#x60;approaching_limit&#x60;, or &#x60;null&#x60; for unlimited plans.</summary>
    [JsonPropertyName("warningThreshold")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int?> WarningThreshold { get; set; }

    /// <summary>Attempted-message count after which new AS2 messages are rejected, or &#x60;null&#x60; for unlimited plans.</summary>
    [JsonPropertyName("rejectionThreshold")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int?> RejectionThreshold { get; set; }

    /// <summary>Days quota-rejected payloads are retained for support recovery, or &#x60;null&#x60; when enforcement is not configured.</summary>
    [JsonPropertyName("quarantineRetentionDays")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int?> QuarantineRetentionDays { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
