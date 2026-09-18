// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Persisted audit and lifecycle state for one transaction replay.</summary>

public sealed class TransactionReplay
{
    /// <summary>Globally unique replay identifier used to correlate regenerated mapping attempts.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>Current replay lifecycle; a synchronous success normally returns &#x60;succeeded&#x60;.</summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary>Source inbound AS2 Message-Id replayed by this operation.</summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string MessageId { get; set; } = default!;

    /// <summary>Source transaction key within the message replayed by this operation.</summary>
    [JsonPropertyName("transactionKey")]
    [JsonRequired]
    public string TransactionKey { get; set; } = default!;

    /// <summary>Mapping revision policy; public replays always use the maps currently published.</summary>
    [JsonPropertyName("mode")]
    [JsonRequired]
    public string Mode { get; set; } = default!;

    /// <summary>Delivery boundary; public replay outputs are returned in the response and never queued or pushed.</summary>
    [JsonPropertyName("delivery")]
    [JsonRequired]
    public string Delivery { get; set; } = default!;

    /// <summary>Internal id of the scoped Integration API key that requested the replay.</summary>
    [JsonPropertyName("requestedByApiKeyId")]
    [JsonRequired]
    public int RequestedByApiKeyId { get; set; } = default!;

    /// <summary>Number of replay execution attempts recorded for this request.</summary>
    [JsonPropertyName("attempts")]
    [JsonRequired]
    public int Attempts { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;.</summary>
    [JsonPropertyName("requestedAt")]
    [JsonRequired]
    public string RequestedAt { get; set; } = default!;

    /// <summary>Caller-supplied operator context, or &#x60;null&#x60; when no reason was provided.</summary>
    [JsonPropertyName("reason")]
    [JsonRequired]
    public string? Reason { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("startedAt")]
    [JsonRequired]
    public string? StartedAt { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("completedAt")]
    [JsonRequired]
    public string? CompletedAt { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("error")]
    [JsonRequired]
    public TransactionReplayError? Error { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
