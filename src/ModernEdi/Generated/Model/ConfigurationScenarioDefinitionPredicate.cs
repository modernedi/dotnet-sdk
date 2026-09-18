// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>A yes/no condition evaluated after the branch&#39;s named checkpoint is emitted. For example, after an X12 301 emits bookingDisposition, compare the cancelRequested run parameter with true to select the X12 303 path. A fact condition must read the common source step of every alternative and that fact&#39;s extract stage must precede the checkpoint; it cannot read a destination document or later pipeline evidence to make that destination eligible. Every condition sees the conversation view from the start of the decision round, so one branch cannot use evidence made available by itself or a sibling branch in that round.</summary>

public sealed class ConfigurationScenarioDefinitionPredicate
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("operator")]
    [JsonRequired]
    public string Operator { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("left")]
    [JsonRequired]
    public ConfigurationScenarioDefinitionValueOperand Left { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("right")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<ConfigurationScenarioDefinitionValueOperand> Right { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
