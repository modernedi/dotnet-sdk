// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>A rule from one document step to another. Correlations identify which actual documents belong together. follows models ordinary order, such as a matching 810 invoice after an 850 order. supersedes records a replacement, such as a later 860 order change replacing the prior 850 or 860. cancels records a removal, such as an ocean 303 cancellation for a 301 booking confirmation. Supersedes and cancels inspect every stored observation before any replacement or cancellation is applied; they do not make an otherwise unavailable next-document path available and cannot themselves be branch alternatives.</summary>

public sealed class ConfigurationScenarioDefinitionTransition
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("fromStep")]
    [JsonRequired]
    public string FromStep { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("toStep")]
    [JsonRequired]
    public string ToStep { get; set; } = default!;

    /// <summary>Choose follows when a matched later document must occur at or after the earlier one, such as an 810 invoice after its 850 order. Choose supersedes when the later document replaces the matched earlier occurrence, such as an 860 order change replacing an 850 or prior 860. Choose cancels when the later document cancels the matched earlier occurrence, such as an ocean 303 cancelling a 301 booking confirmation. supersedes and cancels require effect to say when the change begins and whether later checks keep using the original document or reevaluate with the replacement/removal. Business labels such as acknowledges, reports status, or settles belong in the transition ID and prose unless an assertion or evidence requirement actually verifies them.</summary>
    [JsonPropertyName("relationship")]
    [JsonRequired]
    public string Relationship { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("matching")]
    [JsonRequired]
    public ConfigurationScenarioDefinitionOccurrenceMatching Matching { get; set; } = default!;

    /// <summary>A positive ISO 8601 duration accepted by java.time.Duration, no longer than P365D. Examples: PT30M, PT4H, P2D. The server enforces the upper bound.</summary>
    [JsonPropertyName("within")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> Within { get; set; }

    /// <summary>Conditions the scenario evaluator uses to pair actual source and target documents. For example, compare the purchase-order number extracted from an 850 with the purchase-order number extracted from an 810. Correlation IDs must be unique within this transition.</summary>
    [JsonPropertyName("correlations")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<List<ConfigurationScenarioDefinitionCorrelation>> Correlations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effect")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<ConfigurationScenarioDefinitionRevisionEffect> Effect { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
