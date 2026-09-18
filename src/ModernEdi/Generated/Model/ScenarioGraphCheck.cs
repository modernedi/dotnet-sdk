// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary></summary>

public sealed class ScenarioGraphCheck
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("outcome")]
    [JsonRequired]
    public string Outcome { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("code")]
    [JsonRequired]
    public string Code { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("subjects")]
    [JsonRequired]
    public List<ScenarioGraphCheckSubject> Subjects { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("attributes")]
    [JsonRequired]
    public Dictionary<string, string> Attributes { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
