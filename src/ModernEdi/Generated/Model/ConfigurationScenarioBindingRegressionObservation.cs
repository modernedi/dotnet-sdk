// Generated from the ModernEDI Integration API 1.36.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary></summary>

public sealed class ConfigurationScenarioBindingRegressionObservation
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("stepId")]
    [JsonRequired]
    public string StepId { get; set; } = default!;

    /// <summary>ID of a saved case belonging to this step&#39;s bound runtime mapping. Incoming observations use that case&#39;s selected X12 transaction; outgoing observations use the actual generated output, never expectedOutput.</summary>
    [JsonPropertyName("mappingCaseId")]
    [JsonRequired]
    public string MappingCaseId { get; set; } = default!;

    /// <summary>Whole seconds after the synthetic start (at most 365 days).</summary>
    [JsonPropertyName("observedAfterSeconds")]
    [JsonRequired]
    public int ObservedAfterSeconds { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
