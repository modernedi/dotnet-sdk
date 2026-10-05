// Generated from the ModernEDI Integration API 1.36.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>A FAILED expectation must include at least one specific FAILED check, preventing an unrelated failure from satisfying a negative test.</summary>

public sealed class ConfigurationScenarioBindingRegressionExpected
{
    /// <summary></summary>
    [JsonPropertyName("outcome")]
    [JsonRequired]
    public string Outcome { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("checks")]
    [JsonRequired]
    public List<ConfigurationScenarioBindingRegressionExpectedChecksInner> Checks { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
