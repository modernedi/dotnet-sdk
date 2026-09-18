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

public sealed class IntegrationChangeEvent
{
    /// <summary>Opaque event identifier for logging and deduplication; ordering comes from the cursor.</summary>
    [JsonPropertyName("eventId")]
    [JsonRequired]
    public string EventId { get; set; } = default!;

    /// <summary>Whether reconciliation first observed the transaction or detected a later state change.</summary>
    [JsonPropertyName("type")]
    [JsonRequired]
    public string Type { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;.</summary>
    [JsonPropertyName("observedAt")]
    [JsonRequired]
    public string ObservedAt { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("transaction")]
    [JsonRequired]
    public IntegrationChangeTransactionReference Transaction { get; set; } = default!;

    /// <summary>Public state components that changed; refetch transaction detail for their current values.</summary>
    [JsonPropertyName("changedFields")]
    [JsonRequired]
    public List<IntegrationChangeField> ChangedFields { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
