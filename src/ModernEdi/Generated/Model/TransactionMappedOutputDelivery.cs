// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Handoff state for a mapped output stored on a transaction. This object is present on stored transaction-detail mapped outputs and omitted from response-only replay results, which do not enter the managed queue. &#x60;acknowledged&#x60; means acknowledged by your integration through the queue acknowledgment API or a successful mapped-output webhook; it does not prove how another application handled the document afterward. </summary>

public sealed class TransactionMappedOutputDelivery
{
    /// <summary>&#x60;managed_queue&#x60; exposes a current polling/webhook state; &#x60;not_applicable&#x60; is a transaction-record-only artifact. </summary>
    [JsonPropertyName("applicability")]
    [JsonRequired]
    public string Applicability { get; set; } = default!;

    /// <summary>Current managed-queue state, or null when applicability is not &#x60;managed_queue&#x60;. &#x60;ready&#x60; includes a never-leased output and an output whose prior lease expired. &#x60;leased&#x60; means the visibility timeout is still active. &#x60;acknowledged&#x60; means acknowledged by your integration. </summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string? Status { get; set; } = default!;

    /// <summary>UTC instant when this generated output version became available for polling or webhook delivery. A durable replay creates a new output version with a new availability instant. </summary>
    [JsonPropertyName("availableAt")]
    [JsonRequired]
    public string? AvailableAt { get; set; } = default!;

    /// <summary>Current actionable managed-output handoff issue, or null while the output is progressing normally, acknowledged, or not managed by the queue. &#x60;not_collected&#x60; means no first delivery lease was issued before the 15-minute pickup grace period expired. &#x60;acknowledgment_overdue&#x60; means the first lease expired without acknowledgment. &#x60;redelivered&#x60; means more than one delivery lease was issued without a later acknowledgment. </summary>
    [JsonPropertyName("handoffIssue")]
    [JsonRequired]
    public string? HandoffIssue { get; set; } = default!;

    /// <summary>UTC instant when the current &#x60;handoffIssue&#x60; became actionable, or null when no handoff issue is active. For &#x60;not_collected&#x60;, this is 15 minutes after &#x60;availableAt&#x60;; for an overdue acknowledgment it is the first lease expiry; for a redelivery it is the most recent transition into the redelivered state. </summary>
    [JsonPropertyName("attentionSince")]
    [JsonRequired]
    public string? AttentionSince { get; set; } = default!;

    /// <summary>Managed-queue correlation id for this generated output, or null when queue tracking does not apply. It is distinct from the mapped output&#39;s top-level transaction artifact &#x60;id&#x60;. It stays stable across ordinary processing retries that reproduce the same logical output. A successful durable replay creates a new id even when the regenerated content is identical. Acknowledgment still requires the latest &#x60;receiptHandle&#x60; returned by &#x60;GET /v1/mapped-outputs&#x60;; transaction detail does not provide that receipt handle. </summary>
    [JsonPropertyName("outputId")]
    [JsonRequired]
    public string? OutputId { get; set; } = default!;

    /// <summary>Number of times the output has been leased for pull or webhook delivery attempts, or null when queue tracking does not apply. This count does not imply successful downstream processing. </summary>
    [JsonPropertyName("deliveryCount")]
    [JsonRequired]
    public int? DeliveryCount { get; set; } = default!;

    /// <summary>True after more than one lease or delivery attempt; independent of the current status.</summary>
    [JsonPropertyName("redelivered")]
    [JsonRequired]
    public bool? Redelivered { get; set; } = default!;

    /// <summary>UTC instant when the output was first leased for a pull or webhook delivery attempt.</summary>
    [JsonPropertyName("firstDeliveredAt")]
    [JsonRequired]
    public string? FirstDeliveredAt { get; set; } = default!;

    /// <summary>UTC instant when the output was most recently leased for a pull or webhook delivery attempt.</summary>
    [JsonPropertyName("lastDeliveredAt")]
    [JsonRequired]
    public string? LastDeliveredAt { get; set; } = default!;

    /// <summary>UTC instant when the current visibility lease expires, or null when no lease has been issued.</summary>
    [JsonPropertyName("leasedUntil")]
    [JsonRequired]
    public string? LeasedUntil { get; set; } = default!;

    /// <summary>UTC instant when ModernEDI recorded acknowledgment by the customer&#39;s integration or a successful webhook response. This does not prove later ERP or business processing. </summary>
    [JsonPropertyName("ackedAt")]
    [JsonRequired]
    public string? AckedAt { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
