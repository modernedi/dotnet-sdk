// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Immutable syntax-tree catalog identity used while validating desired mappings. Both fields are null when no active catalog identity is available.</summary>

public sealed class ConfigurationPlanValidationContext
{
    /// <summary>Active immutable syntax-tree catalog revision used by mapping validation.</summary>
    [JsonPropertyName("syntaxTreeCatalogRevision")]
    [JsonRequired]
    public string? SyntaxTreeCatalogRevision { get; set; } = default!;

    /// <summary>Lowercase SHA-256 of the active syntax-tree catalog manifest.</summary>
    [JsonPropertyName("syntaxTreeCatalogManifestSha256")]
    [JsonRequired]
    public string? SyntaxTreeCatalogManifestSha256 { get; set; } = default!;

    /// <summary>Present when scenario bindings are planned. Fences the current definitions, adapters, syntax trees, partners and mappings used for validation; apply rechecks this authority.</summary>
    [JsonPropertyName("scenarioAuthorityEtag")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> ScenarioAuthorityEtag { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
