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

public sealed class ScenarioGraphExecution
{
    /// <summary></summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("runtimeVersion")]
    [JsonRequired]
    public string RuntimeVersion { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("authorityContentSha256")]
    [JsonRequired]
    public string AuthorityContentSha256 { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("parametersContentSha256")]
    [JsonRequired]
    public string ParametersContentSha256 { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
