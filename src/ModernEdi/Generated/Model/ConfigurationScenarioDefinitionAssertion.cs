// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>A fact rule that must hold for the run to pass. For example, exists can require every 810 invoice to expose invoiceTotal, sum_equal can compare shipped and invoiced totals, and monotonic can require successive 315 status timestamps to move forward. Binary operators require right; unary operators reject it.</summary>

public sealed class ConfigurationScenarioDefinitionAssertion
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
