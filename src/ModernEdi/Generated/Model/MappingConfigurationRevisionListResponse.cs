// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Newest-first immutable mapping-configuration history plus the complete currently published transform source and configuration identity.</summary>

public sealed class MappingConfigurationRevisionListResponse
{
    /// <summary>Always &#x60;true&#x60;; failures use the documented error response instead.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary>Stable workspace-scoped mapping id whose configuration history was requested.</summary>
    [JsonPropertyName("mappingId")]
    [JsonRequired]
    public int MappingId { get; set; } = default!;

    /// <summary>Quoted ETag for the complete currently published mapping.</summary>
    [JsonPropertyName("currentEtag")]
    [JsonRequired]
    public string CurrentEtag { get; set; } = default!;

    /// <summary>Complete currently published transform source and exact configuration identity from the same locked snapshot as &#x60;currentEtag&#x60;. This is present even when its chronological revision entry is outside the current page.</summary>
    [JsonPropertyName("currentRevision")]
    [JsonRequired]
    public MappingConfigurationRevisionDetail CurrentRevision { get; set; } = default!;

    /// <summary>Whether another page is available through &#x60;nextCursor&#x60;.</summary>
    [JsonPropertyName("hasMore")]
    [JsonRequired]
    public bool HasMore { get; set; } = default!;

    /// <summary>One newest-first page of unique immutable mapping-configuration summaries. Identical source text can appear in multiple entries when another configuration value differs.</summary>
    [JsonPropertyName("revisions")]
    [JsonRequired]
    public List<MappingConfigurationRevisionSummary> Revisions { get; set; } = default!;

    /// <summary>Opaque cursor for the next chronological page, or &#x60;null&#x60; when no older configuration revisions remain.</summary>
    [JsonPropertyName("nextCursor")]
    [JsonRequired]
    public string? NextCursor { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
