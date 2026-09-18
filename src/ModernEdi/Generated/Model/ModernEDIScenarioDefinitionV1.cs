// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Maps define how documents are processed; scenarios define and prove the business conversation those maps implement. A ScenarioDefinition is the portable recipe for that conversation: who exchanges each X12 business document, which documents belong together, what order and repetition are allowed, and what evidence must pass. Tenant partners, syntax trees, mappings, and executable targets belong in a ScenarioBinding.</summary>

public sealed class ModernEDIScenarioDefinitionV1
{
    /// <summary>Wire-contract version for the generally available ScenarioDefinition contract.</summary>
    [JsonPropertyName("apiVersion")]
    [JsonRequired]
    public string ApiVersion { get; set; } = default!;

    /// <summary>Discriminator for a scenario definition document.</summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    [JsonRequired]
    public ConfigurationScenarioDefinitionMetadata Metadata { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("spec")]
    [JsonRequired]
    public ConfigurationScenarioDefinitionSpec Spec { get; set; } = default!;

    /// <summary>Optional portable tooling hint. It does not participate in the definition&#39;s canonical content hash.</summary>
    [JsonPropertyName("$schema")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> Schema { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
