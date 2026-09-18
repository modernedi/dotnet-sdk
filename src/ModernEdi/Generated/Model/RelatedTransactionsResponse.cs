// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Selected transaction plus outbound replies linked to its inbound AS2 message id.</summary>

public sealed class RelatedTransactionsResponse
{
    /// <summary>Always &#x60;true&#x60;; unknown transactions or authorization failures use an error response.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("transaction")]
    [JsonRequired]
    public TransactionSummary Transaction { get; set; } = default!;

    /// <summary>Compact summaries of linked outbound reply transactions; empty when no replies are recorded. Fetch a selected reply&#39;s detail for its acknowledgment and document index.</summary>
    [JsonPropertyName("relatedTransactions")]
    [JsonRequired]
    public List<TransactionSummary> RelatedTransactions { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
