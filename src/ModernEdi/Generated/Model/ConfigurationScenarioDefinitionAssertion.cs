// Generated from the ModernEDI Integration API 1.36.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>A fact rule that must hold for the run to pass. sum_equal compares overall totals. keyed_sum_equal instead sums decimal amounts per item key across occurrences, then requires identical keys and per-key totals on both sides. keyed_equal requires identical keys and consistent decimal values per key, including across repeated occurrences (useful for unit prices). Keyed comparisons wait for both steps to close before passing and require keyed_facts operands. Binary operators require right; unary operators reject it.</summary>

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
    public ConfigurationScenarioDefinitionAssertionOperand Left { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("right")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<ConfigurationScenarioDefinitionAssertionOperand> Right { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
