// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One bounded poll of application-facing mapped outputs from the selected environment.</summary>

public sealed class MappedOutputQueueResponse
{
    /// <summary>Always &#x60;true&#x60;; authentication or queue failures use the documented error response instead.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary>Outputs leased to this poll; acknowledge each successfully persisted item using its id and latest receipt handle.</summary>
    [JsonPropertyName("messages")]
    [JsonRequired]
    public List<MappedOutputMessage> Messages { get; set; } = default!;

    /// <summary>Maximum number of deliverable messages requested for this poll, after server bounds are applied.</summary>
    [JsonPropertyName("limit")]
    [JsonRequired]
    public int Limit { get; set; } = default!;

    /// <summary>Lease duration in seconds; unacknowledged messages may be redelivered after this interval.</summary>
    [JsonPropertyName("visibilityTimeoutSeconds")]
    [JsonRequired]
    public int VisibilityTimeoutSeconds { get; set; } = default!;

    /// <summary>True when &#x60;nextCursor&#x60; should be used to continue scanning.</summary>
    [JsonPropertyName("hasMore")]
    [JsonRequired]
    public bool HasMore { get; set; } = default!;

    /// <summary>Opaque position for the next bounded scan. Send this value as the next poll&#39;s &#x60;cursor&#x60; whenever &#x60;hasMore&#x60; is true. </summary>
    [JsonPropertyName("nextCursor")]
    [JsonRequired]
    public string? NextCursor { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
