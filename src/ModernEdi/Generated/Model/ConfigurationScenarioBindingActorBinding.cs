// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Connects one definition actor to this workspace or a current trading partner.</summary>

public sealed class ConfigurationScenarioBindingActorBinding
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("actorId")]
    [JsonRequired]
    public string ActorId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    [JsonRequired]
    public ConfigurationScenarioBindingEndpoint Endpoint { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
