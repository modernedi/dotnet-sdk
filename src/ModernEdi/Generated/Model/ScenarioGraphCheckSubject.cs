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

public sealed class ScenarioGraphCheckSubject
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("stepId")]
    [JsonRequired]
    public string StepId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("occurrence")]
    [JsonRequired]
    public int Occurrence { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("redacted")]
    [JsonRequired]
    public bool Redacted { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("evidenceReferences")]
    [JsonRequired]
    public List<string> EvidenceReferences { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("fact")]
    [JsonRequired]
    public string? Fact { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("sensitivity")]
    [JsonRequired]
    public string? Sensitivity { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
