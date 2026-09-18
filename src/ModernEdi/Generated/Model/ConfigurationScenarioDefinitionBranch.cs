// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>A choice between mutually exclusive next-document paths after a named checkpoint. The checkpoint must be emitted by the alternatives&#39; shared source step, so the decision precedes every controlled destination. The emitter must also necessarily observe at least one document; expected_count closure with occurrence min 0 cannot emit a branch checkpoint. All alternatives leave the same source step. Example: after a 301 booking confirmation emits bookingDisposition, choose the 303 cancellation path when cancelRequested&#x3D;true; otherwise choose 304 shipping instructions. exactly_one must choose one path and therefore requires an otherwise fallback. at_most_one may choose no path. A round evaluates only evidence already available when that round began; its selection can make later steps available in the next round.</summary>

public sealed class ConfigurationScenarioDefinitionBranch
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("mode")]
    [JsonRequired]
    public string Mode { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("checkpoint")]
    [JsonRequired]
    public string Checkpoint { get; set; } = default!;

    /// <summary>at_most_one accepts one or more when alternatives; exactly_one requires at least two alternatives and exactly one otherwise.</summary>
    [JsonPropertyName("alternatives")]
    [JsonRequired]
    public List<ConfigurationScenarioDefinitionBranchAlternative> Alternatives { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
