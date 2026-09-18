// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One machine-readable planning error or warning. &#x60;pointer&#x60; is an RFC 6901 JSON Pointer into the submitted request body; source diagnostics may also identify an exact file, line, and column.</summary>

public sealed class ConfigurationPlanDiagnostic
{
    /// <summary></summary>
    [JsonPropertyName("severity")]
    [JsonRequired]
    public string Severity { get; set; } = default!;

    /// <summary>Stable machine-readable diagnostic code.</summary>
    [JsonPropertyName("code")]
    [JsonRequired]
    public string Code { get; set; } = default!;

    /// <summary>Plain-language explanation suitable for an operator or authoring tool.</summary>
    [JsonPropertyName("message")]
    [JsonRequired]
    public string Message { get; set; } = default!;

    /// <summary>RFC 6901 JSON Pointer into the submitted &#x60;ConfigurationPlanRequest&#x60;; the empty string identifies the request root.</summary>
    [JsonPropertyName("pointer")]
    [JsonRequired]
    public string Pointer { get; set; } = default!;

    /// <summary>Logical bundle path associated with this diagnostic when one file can be identified.</summary>
    [JsonPropertyName("filePath")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> FilePath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resource")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<ConfigurationPlanResourceIdentity> Resource { get; set; }

    /// <summary>One-based source line when a mapping compiler supplies a location.</summary>
    [JsonPropertyName("line")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int> Line { get; set; }

    /// <summary>One-based source column when a mapping compiler supplies a location.</summary>
    [JsonPropertyName("column")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int> Column { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
