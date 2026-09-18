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

public sealed class ScenarioEvidencePartnerAuthority
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("actorId")]
    [JsonRequired]
    public string ActorId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public long Id { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("configurationSha256")]
    [JsonRequired]
    public string ConfigurationSha256 { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
