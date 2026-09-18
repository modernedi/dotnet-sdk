// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Connects one definition step to an executable or observation target and binds every declared semantic fact to an implementation-guide source. syntaxTree is optional while authoring; Apply resolves an exact authoritative syntax-tree artifact before runtime execution.</summary>

public sealed class ConfigurationScenarioBindingStepBinding
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("stepId")]
    [JsonRequired]
    public string StepId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("target")]
    [JsonRequired]
    public ConfigurationScenarioBindingTarget Target { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("syntaxTree")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<ConfigurationScenarioBindingSyntaxTreeReference> SyntaxTree { get; set; }

    /// <summary>One source for every fact declared by this ScenarioDefinition step. Omission is a deliberate authoring shorthand only when the step declares no facts; canonical Apply materializes an empty array. Server validation otherwise requires exact fact-name coverage. Collection shape, element type, cardinality, normalization, and sensitivity come only from the declaration and are intentionally not duplicated here.</summary>
    [JsonPropertyName("factSources")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<List<ConfigurationScenarioBindingFactSourceBinding>> FactSources { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
