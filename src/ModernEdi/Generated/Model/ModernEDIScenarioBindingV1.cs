// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>A tenant-scoped authoring binding that connects every actor and step in one immutable ScenarioDefinition to current workspace partners and executable targets. It references tenant artifacts by identity and contains no copied runtime configuration, credentials, private keys, or other secrets.</summary>

public sealed class ModernEDIScenarioBindingV1
{
    /// <summary>Wire-contract version for tenant-authored scenario bindings.</summary>
    [JsonPropertyName("apiVersion")]
    [JsonRequired]
    public string ApiVersion { get; set; } = default!;

    /// <summary>Discriminator for a scenario binding document.</summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    [JsonRequired]
    public ConfigurationScenarioBindingMetadata Metadata { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("spec")]
    [JsonRequired]
    public ConfigurationScenarioBindingSpec Spec { get; set; } = default!;

    /// <summary>Optional portable tooling hint. It does not participate in the binding&#39;s canonical content hash.</summary>
    [JsonPropertyName("$schema")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> Schema { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
