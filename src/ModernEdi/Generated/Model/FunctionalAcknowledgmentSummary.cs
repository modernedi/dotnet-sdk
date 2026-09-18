// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Compact whole-997 aggregate included on transaction summaries for list-level monitoring. Full AK1/AK9 and AK2/AK5 trees are reserved for detail; use the row&#39;s separate &#x60;functionalAckGroupOutcome&#x60; and &#x60;functionalAckTransactionOutcome&#x60; projections for attribution. Only &#x60;accepted&#x60; is a clean automation completion. &#x60;accepted_with_errors&#x60; and &#x60;unknown&#x60; require review; &#x60;partially_accepted&#x60; and &#x60;rejected&#x60; are failure or rejection outcomes that require action. </summary>

public sealed class FunctionalAcknowledgmentSummary
{
    /// <summary></summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Human-readable whole-997 aggregate result.</summary>
    [JsonPropertyName("summary")]
    [JsonRequired]
    public string Summary { get; set; } = default!;

    /// <summary>Original AK901 functional-group acknowledgment code, when available.</summary>
    [JsonPropertyName("acknowledgmentCode")]
    [JsonRequired]
    public string? AcknowledgmentCode { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
