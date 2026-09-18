// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>A condition that decides whether two actual documents belong to the same transition pair. equal can match the purchase-order number on an 850 and 810; same_set can compare their item sets; reply_link uses ModernEDI&#39;s stored reply relationship and accepts no fact operands.</summary>

public sealed class ConfigurationScenarioDefinitionCorrelation
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<ConfigurationScenarioDefinitionFactOperand> Left { get; set; }

    /// <summary></summary>
    [JsonPropertyName("right")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<ConfigurationScenarioDefinitionFactOperand> Right { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
