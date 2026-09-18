// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Identity and coverage of one tested mapping.</summary>

public sealed class ConfigurationVerificationMapping
{
    /// <summary>Stable portable Mapping resource key.</summary>
    [JsonPropertyName("mappingResourceKey")]
    [JsonRequired]
    public string MappingResourceKey { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("candidateSha256")]
    [JsonRequired]
    public string CandidateSha256 { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("casesSha256")]
    [JsonRequired]
    public string CasesSha256 { get; set; } = default!;

    /// <summary>Number of saved cases selected for this mapping.</summary>
    [JsonPropertyName("caseCount")]
    [JsonRequired]
    public int CaseCount { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("syntaxTree")]
    [JsonRequired]
    public ConfigurationVerificationSyntaxTree SyntaxTree { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
