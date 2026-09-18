// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Compact 999 aggregate and group results included on transaction summaries for list-level monitoring.</summary>

public sealed class ImplementationAcknowledgmentSummary
{
    /// <summary></summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Human-readable aggregate 999 result.</summary>
    [JsonPropertyName("summary")]
    [JsonRequired]
    public string Summary { get; set; } = default!;

    /// <summary>Compact response retains each AK1/AK9 group so transactions can be evaluated without collapsing sibling groups.</summary>
    [JsonPropertyName("groups")]
    [JsonRequired]
    public List<ImplementationAcknowledgmentGroupOutcome> Groups { get; set; } = default!;

    /// <summary>Aggregate acknowledgment code when one value represents the whole 999, or &#x60;null&#x60; for mixed or unavailable group results.</summary>
    [JsonPropertyName("acknowledgmentCode")]
    [JsonRequired]
    public string? AcknowledgmentCode { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
