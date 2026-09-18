// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Environment-wide summary of retained mapping failures and recoveries.</summary>

public sealed class MappingRuntimeHealthResponse
{
    /// <summary>Always &#x60;true&#x60;; authorization, billing, or runtime-read failures use an error response.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;.</summary>
    [JsonPropertyName("generatedAt")]
    [JsonRequired]
    public string GeneratedAt { get; set; } = default!;

    /// <summary>True when the bounded health scan could not summarize every retained attempt.</summary>
    [JsonPropertyName("truncated")]
    [JsonRequired]
    public bool Truncated { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("totals")]
    [JsonRequired]
    public MappingRuntimeHealthTotals Totals { get; set; } = default!;

    /// <summary>Mapping- or unmatched-request-level groups with failure or recovery activity.</summary>
    [JsonPropertyName("mappings")]
    [JsonRequired]
    public List<MappingRuntimeMappingHealth> Mappings { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
