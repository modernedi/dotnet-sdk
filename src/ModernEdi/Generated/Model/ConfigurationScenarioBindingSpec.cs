// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>References one exact published definition and binds all of its actors and steps. Apply resolves and freezes authoritative artifacts for runtime use.</summary>

public sealed class ConfigurationScenarioBindingSpec
{
    /// <summary></summary>
    [JsonPropertyName("definition")]
    [JsonRequired]
    public ConfigurationScenarioBindingDefinitionReference Definition { get; set; } = default!;

    /// <summary>Required workspace traffic selector, frozen into the applied binding. Production and test traffic use the same deployed mappings; this does not deploy unpublished mappings or create another workspace. Runs use the selected AS2/X12 profile and keep transaction lookup, acknowledgments, and evidence in that environment, without falling back to the other profile.</summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary>Exactly one binding for every definition actor. IDs must be unique; exactly one endpoint must be this workspace and at least one must be a current external partner.</summary>
    [JsonPropertyName("actors")]
    [JsonRequired]
    public List<ConfigurationScenarioBindingActorBinding> Actors { get; set; } = default!;

    /// <summary>Exactly one binding for every definition step. IDs must be unique.</summary>
    [JsonPropertyName("steps")]
    [JsonRequired]
    public List<ConfigurationScenarioBindingStepBinding> Steps { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
