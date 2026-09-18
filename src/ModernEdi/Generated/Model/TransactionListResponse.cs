// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Paginated transaction summaries plus an environment-wide operator-attention count and freshness state.</summary>

public sealed class TransactionListResponse
{
    /// <summary>Always &#x60;true&#x60;; query or authorization failures use the documented error response instead.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary>Transactions matching the requested filters and cursor page, ordered newest first.</summary>
    [JsonPropertyName("transactions")]
    [JsonRequired]
    public List<TransactionSummary> Transactions { get; set; } = default!;

    /// <summary>True when &#x60;nextCursor&#x60; should be sent unchanged to retrieve another page.</summary>
    [JsonPropertyName("hasMore")]
    [JsonRequired]
    public bool HasMore { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("window")]
    [JsonRequired]
    public TransactionWindow Window { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("attentionSummary")]
    [JsonRequired]
    public TransactionAttentionSummary AttentionSummary { get; set; } = default!;

    /// <summary>Opaque cursor for the next page, or &#x60;null&#x60; when no further matching transactions remain.</summary>
    [JsonPropertyName("nextCursor")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> NextCursor { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
