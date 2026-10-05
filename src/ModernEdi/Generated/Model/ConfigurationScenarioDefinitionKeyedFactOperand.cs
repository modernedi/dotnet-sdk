// Generated from the ModernEDI Integration API 1.36.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Conversation assertion input: align the required string-list keyFact and required decimal-list fact by index within each effective occurrence of stepId. List lengths must agree. Keys must be nonblank and unique within each occurrence; the same key may recur in later documents. Both the keys and values retain source evidence. No projection or parameter is accepted. This does not combine quantities in different units: include unit in your Mapper-produced key. Keyed operators are not available in branch predicates, correlations, or revision timestamps.</summary>

public sealed class ConfigurationScenarioDefinitionKeyedFactOperand
{
    /// <summary></summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("stepId")]
    [JsonRequired]
    public string StepId { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("keyFact")]
    [JsonRequired]
    public string KeyFact { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("fact")]
    [JsonRequired]
    public string Fact { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
