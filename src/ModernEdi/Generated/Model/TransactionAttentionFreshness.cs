// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Reconciliation state for the selected environment. Until the first complete sweep, attention-filtered or exact-status-filtered rows and counts can be partial or empty; &#x60;complete: false&#x60; means an empty result is not proof of zero. An incomplete or failed sweep does not clear previously observed active attention items. </summary>

public sealed class TransactionAttentionFreshness
{
    /// <summary>Reconciliation lifecycle: pending, actively reconciling, current, or stale.</summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Whether the currently reported projection is complete and current. This is false while the first sweep is pending, while a refresh is reconciling, or when reconciliation is stale; previously observed active items remain visible during those states. </summary>
    [JsonPropertyName("complete")]
    [JsonRequired]
    public bool Complete { get; set; } = default!;

    /// <summary>UTC instant of the latest completed full attention sweep, or &#x60;null&#x60; before the first completion.</summary>
    [JsonPropertyName("lastCompletedAt")]
    [JsonRequired]
    public string? LastCompletedAt { get; set; } = default!;

    /// <summary>UTC instant when the current reconciliation began, or &#x60;null&#x60; when no sweep is running.</summary>
    [JsonPropertyName("reconciliationStartedAt")]
    [JsonRequired]
    public string? ReconciliationStartedAt { get; set; } = default!;

    /// <summary>Safe operator-facing freshness or retry guidance; internal errors are not exposed.</summary>
    [JsonPropertyName("message")]
    [JsonRequired]
    public string? Message { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
