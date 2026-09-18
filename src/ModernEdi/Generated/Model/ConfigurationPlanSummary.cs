// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Resource counts across the complete desired/current comparison.</summary>

public sealed class ConfigurationPlanSummary
{
    /// <summary></summary>
    [JsonPropertyName("create")]
    [JsonRequired]
    public int Create { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("update")]
    [JsonRequired]
    public int Update { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("delete")]
    [JsonRequired]
    public int Delete { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("unchanged")]
    [JsonRequired]
    public int Unchanged { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
