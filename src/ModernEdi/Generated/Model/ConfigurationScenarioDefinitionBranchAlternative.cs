// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One ordinary follows transition that a branch may select, either when its conditions pass or as the explicit otherwise fallback. For example, cancelRequested&#x3D;true selects the 301-to-303 follows transition; otherwise selects 301-to-304. supersedes and cancels transitions are revision records, not branch alternatives.</summary>

public sealed class ConfigurationScenarioDefinitionBranchAlternative
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("transitionId")]
    [JsonRequired]
    public string TransitionId { get; set; } = default!;

    /// <summary>Conditions may use parameters, literals, or facts from the alternatives&#39; shared fromStep. They cannot read a destination step to select that destination.</summary>
    [JsonPropertyName("conditions")]
    [JsonRequired]
    public List<ConfigurationScenarioDefinitionPredicate> Conditions { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
