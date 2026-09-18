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

public sealed class ScenarioRunActorOneOf
{
    /// <summary></summary>
    [JsonPropertyName("memberId")]
    [JsonRequired]
    public long MemberId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("email")]
    [JsonRequired]
    public string Email { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("role")]
    [JsonRequired]
    public string Role { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
