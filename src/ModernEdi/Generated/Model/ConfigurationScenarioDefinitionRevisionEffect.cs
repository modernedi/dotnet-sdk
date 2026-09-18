// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>What a matched replacement or cancellation changes. Raw immutable observation history means every received document remains stored unchanged; the revision rule changes only the run&#39;s interpreted business view. A revision transition does not open a next-document path by itself. Each branch-decision round first snapshots the steps already allowed; its conditions see only active reevaluate effects whose original and later-document steps are both in that snapshot, and a chosen path becomes available only in the next round. After branch selection, a revision affects checks only when both endpoint steps remain on the selected conversation path. If several active reevaluate effects target the same original document, the later effectiveAt wins; equal latest times fail with REVISION_EFFECT_CONFLICT instead of choosing arbitrarily.</summary>

public sealed class ConfigurationScenarioDefinitionRevisionEffect
{
    /// <summary></summary>
    [JsonPropertyName("effectiveAt")]
    [JsonRequired]
    public ConfigurationScenarioDefinitionEffectiveAt EffectiveAt { get; set; } = default!;

    /// <summary>retain records the change and effective time but keeps using the original document for branch conditions, ordinary follows transitions, and assertions; for example, record an advisory 860 while later shipment checks still use the original 850. reevaluate recomputes those same consumers with the replacement or removal; for example, use the revised 860 values for later 856/810 checks, or remove a 301 booking confirmation after its 303 cancellation.</summary>
    [JsonPropertyName("downstream")]
    [JsonRequired]
    public string Downstream { get; set; } = default!;

    /// <summary>Behavior when no prior effective occurrence can be revised or cancelled. previous matching requires record because the first occurrence is the initial revision and necessarily has no prior occurrence.</summary>
    [JsonPropertyName("unmatched")]
    [JsonRequired]
    public string Unmatched { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
