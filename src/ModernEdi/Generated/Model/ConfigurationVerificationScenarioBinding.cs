// Generated from the ModernEDI Integration API 1.36.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary></summary>

public sealed class ConfigurationVerificationScenarioBinding
{
    /// <summary>Stable portable ScenarioBinding resource key.</summary>
    [JsonPropertyName("scenarioBindingResourceKey")]
    [JsonRequired]
    public string ScenarioBindingResourceKey { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("definitionSha256")]
    [JsonRequired]
    public string DefinitionSha256 { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("bindingSha256")]
    [JsonRequired]
    public string BindingSha256 { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("authoritySha256")]
    [JsonRequired]
    public string AuthoritySha256 { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("casesSha256")]
    [JsonRequired]
    public string CasesSha256 { get; set; } = default!;

    /// <summary>Number of saved conversation tests selected from this binding.</summary>
    [JsonPropertyName("caseCount")]
    [JsonRequired]
    public int CaseCount { get; set; } = default!;

    /// <summary>Frozen X12 grammar for every bound step, including steps absent from an individual test.</summary>
    [JsonPropertyName("steps")]
    [JsonRequired]
    public List<ConfigurationVerificationScenarioStep> Steps { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
