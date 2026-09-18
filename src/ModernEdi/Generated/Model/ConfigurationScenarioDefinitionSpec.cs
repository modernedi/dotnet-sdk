// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>The business-conversation recipe. Actors name the business roles, steps name their X12 document exchanges, and transitions state how those exchanges relate. ModernEDI also verifies unique IDs, references, a connected conversation, and the absence of ordinary transition cycles during Validate and Publish. Omitted transitions, assertions, parameters, checkpoints, or branches mean empty arrays; published JSON materializes every collection.</summary>

public sealed class ConfigurationScenarioDefinitionSpec
{
    /// <summary>Business roles participating in the conversation. Every actor ID must be unique.</summary>
    [JsonPropertyName("actors")]
    [JsonRequired]
    public List<ConfigurationScenarioDefinitionActor> Actors { get; set; } = default!;

    /// <summary>Business-document exchanges. Every step ID must be unique and must reference two different declared actors.</summary>
    [JsonPropertyName("steps")]
    [JsonRequired]
    public List<ConfigurationScenarioDefinitionStep> Steps { get; set; } = default!;

    /// <summary>Rules connecting document steps. For example, an 810 invoice can follow its matching 850 purchase order, a later 860 can supersede an earlier order change, and an ocean 303 can cancel a matching 301 booking confirmation. Transition IDs must be unique. Except for a same-step supersedes revision chain, ordinary next-document paths cannot loop and every step must belong to one connected conversation.</summary>
    [JsonPropertyName("transitions")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<List<ConfigurationScenarioDefinitionTransition>> Transitions { get; set; }

    /// <summary>Run-level facts that must hold across one or more observed step occurrences. Assertion IDs must be unique.</summary>
    [JsonPropertyName("assertions")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<List<ConfigurationScenarioDefinitionAssertion>> Assertions { get; set; }

    /// <summary>Prepared values supplied when a run starts. Parameters declare only their semantic type, required flag, and optional default; bindings and runtime APIs supply values.</summary>
    [JsonPropertyName("parameters")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<List<ConfigurationScenarioDefinitionParameter>> Parameters { get; set; }

    /// <summary>Named completion events emitted after a step finishes a declared processing stage. A checkpoint can trigger a choice between allowed next steps. For example, a bookingDisposition checkpoint emitted after an X12 301 booking confirmation can choose between an X12 303 cancellation and X12 304 shipping instructions.</summary>
    [JsonPropertyName("checkpoints")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<List<ConfigurationScenarioDefinitionCheckpoint>> Checkpoints { get; set; }

    /// <summary>Explicit choices between allowed next-document transitions, evaluated only after a named checkpoint is emitted. For example, after an X12 301 booking confirmation emits bookingDisposition, cancelRequested&#x3D;true can select the X12 303 cancellation path and otherwise can select X12 304 shipping instructions. Choices are evaluated in deterministic rounds from the steps already available at the start of that round; a destination document cannot provide the fact that selects its own path.</summary>
    [JsonPropertyName("branches")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<List<ConfigurationScenarioDefinitionBranch>> Branches { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
