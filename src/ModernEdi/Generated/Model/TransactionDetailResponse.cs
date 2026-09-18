// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Metadata-first transaction record with a document index, mapping results, delivery state, acknowledgments, events, and compact linked-reply summaries.</summary>

public sealed class TransactionDetailResponse
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
    public TransactionDetail Transaction { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
