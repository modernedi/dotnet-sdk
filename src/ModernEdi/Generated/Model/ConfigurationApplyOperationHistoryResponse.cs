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

public sealed class ConfigurationApplyOperationHistoryResponse
{
    /// <summary></summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("operations")]
    [JsonRequired]
    public List<ConfigurationApplyOperationHistoryEntry> Operations { get; set; } = default!;

    /// <summary>Opaque cursor for the next page, or null at the end.</summary>
    [JsonPropertyName("nextCursor")]
    [JsonRequired]
    public string? NextCursor { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
