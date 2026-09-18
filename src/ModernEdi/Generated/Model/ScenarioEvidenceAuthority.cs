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

public sealed class ScenarioEvidenceAuthority
{
    /// <summary></summary>
    [JsonPropertyName("partners")]
    [JsonRequired]
    public List<ScenarioEvidencePartnerAuthority> Partners { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("mappings")]
    [JsonRequired]
    public List<ScenarioEvidenceMappingAuthority> Mappings { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("syntaxTrees")]
    [JsonRequired]
    public List<ScenarioEvidenceSyntaxTreeAuthority> SyntaxTrees { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("targets")]
    [JsonRequired]
    public List<ScenarioEvidenceTargetAuthority> Targets { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
