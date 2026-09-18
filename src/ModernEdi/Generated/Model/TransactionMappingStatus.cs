// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary></summary>

public sealed class TransactionMappingStatus
{
    /// <summary>Consolidated mapping outcome. &#x60;NOT_RECORDED&#x60; means no mapping runtime result was found; it does not claim that a map ran successfully. &#x60;UNAVAILABLE&#x60; means mapping telemetry could not be read while this response was built. It is fail-soft, has &#x60;failureCount: 0&#x60;, and does not by itself set &#x60;needsAttention&#x60;; retry before drawing a conclusion. &#x60;RECOVERED&#x60; means earlier failures were resolved by a later successful attempt. &#x60;COMPLETED_WITH_ERRORS&#x60; means at least one attempt succeeded while another failure remains unresolved. </summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Number of unresolved mapping failures for this transaction.</summary>
    [JsonPropertyName("failureCount")]
    [JsonRequired]
    public int FailureCount { get; set; } = default!;

    /// <summary>Mapping attempts in reverse chronological order. This is empty when only fallback post-process status is available.</summary>
    [JsonPropertyName("attempts")]
    [JsonRequired]
    public List<TransactionMappingAttempt> Attempts { get; set; } = default!;

    /// <summary>Timestamp of the latest mapping attempt or fallback post-process status.</summary>
    [JsonPropertyName("latestAttemptAt")]
    [JsonRequired]
    public string? LatestAttemptAt { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
