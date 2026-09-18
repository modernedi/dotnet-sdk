// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One changed resource. CREATE has only &#x60;desired&#x60;, UPDATE has &#x60;current&#x60; and &#x60;desired&#x60;, and DELETE has only &#x60;current&#x60;.</summary>

public sealed class ConfigurationPlanOperation
{
    /// <summary></summary>
    [JsonPropertyName("action")]
    [JsonRequired]
    public string Action { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary>Stable portable resource key.</summary>
    [JsonPropertyName("key")]
    [JsonRequired]
    public string Key { get; set; } = default!;

    /// <summary>Desired resource path for CREATE/UPDATE or current exported path for DELETE.</summary>
    [JsonPropertyName("path")]
    [JsonRequired]
    public string Path { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("current")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<ConfigurationPlanCurrentValue> Current { get; set; }

    /// <summary></summary>
    [JsonPropertyName("desired")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<ConfigurationPlanDesiredValue> Desired { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
