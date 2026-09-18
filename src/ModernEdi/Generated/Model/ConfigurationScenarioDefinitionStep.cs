// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One directed X12 business-document exchange. Functional acknowledgments (997/999) are evidence requirements, not business steps.</summary>

public sealed class ConfigurationScenarioDefinitionStep
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("fromActor")]
    [JsonRequired]
    public string FromActor { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("toActor")]
    [JsonRequired]
    public string ToActor { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("transaction")]
    [JsonRequired]
    public ConfigurationScenarioDefinitionTransaction Transaction { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("occurrence")]
    [JsonRequired]
    public ConfigurationScenarioDefinitionOccurrence Occurrence { get; set; } = default!;

    /// <summary>Typed semantic facts exposed by this step. Use an empty array when the step exposes none. Declarations name the stable ABI only; extraction provenance belongs to runtime capability and binding layers.</summary>
    [JsonPropertyName("facts")]
    [JsonRequired]
    public List<ConfigurationScenarioDefinitionFactDeclaration> Facts { get; set; } = default!;

    /// <summary>Ordered abstract processing stages for each step occurrence. Stages describe behavior without naming mapper or transport artifacts.</summary>
    [JsonPropertyName("pipeline")]
    [JsonRequired]
    public List<ConfigurationScenarioDefinitionPipelineStage> Pipeline { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("assurance")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<ConfigurationScenarioDefinitionAssurance> Assurance { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
