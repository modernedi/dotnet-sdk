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

public sealed class ConfigurationExternalRepositoryLastError
{
    /// <summary>Diagnostic code; new codes may be added.</summary>
    [JsonPropertyName("code")]
    [JsonRequired]
    public string Code { get; set; } = default!;

    /// <summary>Safe operator-facing explanation; not raw provider output.</summary>
    [JsonPropertyName("message")]
    [JsonRequired]
    public string Message { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
