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

public sealed class MappingRuntimeMappingHealth
{
    /// <summary>Whether the grouped attempt hash is still the currently published source.</summary>
    [JsonPropertyName("currentRevision")]
    [JsonRequired]
    public bool CurrentRevision { get; set; } = default!;

    /// <summary>Unresolved failures in this group.</summary>
    [JsonPropertyName("failureCount")]
    [JsonRequired]
    public int FailureCount { get; set; } = default!;

    /// <summary>Resolved failures in this group.</summary>
    [JsonPropertyName("recoveredCount")]
    [JsonRequired]
    public int RecoveredCount { get; set; } = default!;

    /// <summary>Mapping id, or &#x60;null&#x60; for a request that failed before map selection.</summary>
    [JsonPropertyName("mappingId")]
    [JsonRequired]
    public int? MappingId { get; set; } = default!;

    /// <summary>Transform filename, or &#x60;null&#x60; when no map was selected.</summary>
    [JsonPropertyName("mapFile")]
    [JsonRequired]
    public string? MapFile { get; set; } = default!;

    /// <summary>Base64 SHA-256 hash of the attempted mapping source, when known.</summary>
    [JsonPropertyName("mapFileSha256Hash")]
    [JsonRequired]
    public string? MapFileSha256Hash { get; set; } = default!;

    /// <summary>Mapping direction, or &#x60;null&#x60; when it was not attributable.</summary>
    [JsonPropertyName("direction")]
    [JsonRequired]
    public string? Direction { get; set; } = default!;

    /// <summary>Tenant-scoped partner id, or &#x60;null&#x60; when no partner was resolved.</summary>
    [JsonPropertyName("partnerId")]
    [JsonRequired]
    public int? PartnerId { get; set; } = default!;

    /// <summary>Partner name captured for the attempt, when known.</summary>
    [JsonPropertyName("partnerName")]
    [JsonRequired]
    public string? PartnerName { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("latestAt")]
    [JsonRequired]
    public string? LatestAt { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
