// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Current UTC-day message quota, enforcement state, history, and workload signals.</summary>

public sealed class UsageResponse
{
    /// <summary>Always &#x60;true&#x60;; authorization or telemetry failures use an error response.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("usage")]
    [JsonRequired]
    public UsageSnapshot Usage { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
