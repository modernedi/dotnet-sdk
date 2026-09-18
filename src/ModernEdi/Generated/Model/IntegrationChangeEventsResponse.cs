// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Bootstrap cursor or chronological page of transaction-state invalidations.</summary>

public sealed class IntegrationChangeEventsResponse
{
    /// <summary>Always &#x60;true&#x60;; invalid or expired cursors use a structured error response.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary>Events strictly after the supplied cursor, ordered by detection sequence.</summary>
    [JsonPropertyName("events")]
    [JsonRequired]
    public List<IntegrationChangeEvent> Events { get; set; } = default!;

    /// <summary>Opaque, integrity-protected cursor bound to this tenant and environment. Return it unchanged on the next poll, including after an empty page. Editing it or using it for another tenant or environment returns HTTP 400. </summary>
    [JsonPropertyName("nextCursor")]
    [JsonRequired]
    public string NextCursor { get; set; } = default!;

    /// <summary>True when another page is already available after &#x60;nextCursor&#x60;.</summary>
    [JsonPropertyName("hasMore")]
    [JsonRequired]
    public bool HasMore { get; set; } = default!;

    /// <summary>True only when the request omitted &#x60;cursor&#x60; and established a high-water mark.</summary>
    [JsonPropertyName("bootstrap")]
    [JsonRequired]
    public bool Bootstrap { get; set; } = default!;

    /// <summary>Rolling retention of this invalidation feed; independent of transaction-document retention.</summary>
    [JsonPropertyName("retentionSeconds")]
    [JsonRequired]
    public int RetentionSeconds { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("freshness")]
    [JsonRequired]
    public TransactionAttentionFreshness Freshness { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
