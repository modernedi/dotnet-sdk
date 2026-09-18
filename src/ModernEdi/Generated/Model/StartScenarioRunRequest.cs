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

public sealed class StartScenarioRunRequest
{
    /// <summary></summary>
    [JsonPropertyName("definition")]
    [JsonRequired]
    public ScenarioDefinitionIdentity Definition { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("binding")]
    [JsonRequired]
    public StartScenarioRunRequestBinding Binding { get; set; } = default!;

    /// <summary>Values keyed by declared definition parameter ID. The server rejects unknown, missing-required, or type-invalid values and materializes declared defaults before hashing the run input. Raw parameter values are never returned by the run API.</summary>
    [JsonPropertyName("parameters")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<Dictionary<string, ScenarioRunParameterValue>> Parameters { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
