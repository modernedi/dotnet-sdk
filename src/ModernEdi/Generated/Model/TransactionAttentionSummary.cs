// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Environment-wide operator-inbox summary. Counts are independent of the transaction list&#39;s date window, row limit, cursor, and other filters. A transaction with more than one reason is counted once in &#x60;needsAttentionCount&#x60; and once in each applicable reason count. Its &#x60;freshness&#x60; also applies to &#x60;mappingStatus&#x60;, &#x60;functionalAckStatus&#x60;, &#x60;implementationAckStatus&#x60;, and &#x60;mdnStatus&#x60; list filtering and to list-level projected MDN status. </summary>

public sealed class TransactionAttentionSummary
{
    /// <summary>Distinct transactions currently projected as needing attention.</summary>
    [JsonPropertyName("needsAttentionCount")]
    [JsonRequired]
    public int NeedsAttentionCount { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("reasonCounts")]
    [JsonRequired]
    public TransactionAttentionSummaryReasonCounts ReasonCounts { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("freshness")]
    [JsonRequired]
    public TransactionAttentionFreshness Freshness { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
