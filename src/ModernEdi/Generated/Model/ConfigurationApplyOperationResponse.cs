// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Stored tenant-scoped result of one idempotent aggregate apply request.</summary>

public sealed class ConfigurationApplyOperationResponse
{
    /// <summary>Always &#x60;true&#x60;; rejected requests use the standard error envelope.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("operation")]
    [JsonRequired]
    public ConfigurationApplyOperation Operation { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
