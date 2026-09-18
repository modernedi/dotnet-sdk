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

public sealed class ScenarioEvidenceStep
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("stepId")]
    [JsonRequired]
    public string StepId { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("fromActor")]
    [JsonRequired]
    public string FromActor { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("toActor")]
    [JsonRequired]
    public string ToActor { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("transactionSet")]
    [JsonRequired]
    public string TransactionSet { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("direction")]
    [JsonRequired]
    public string Direction { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("targetKind")]
    [JsonRequired]
    public string TargetKind { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("occurrences")]
    [JsonRequired]
    public List<ScenarioEvidenceOccurrence> Occurrences { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
