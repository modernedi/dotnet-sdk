// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Server-derived identity of the reviewed configuration and evaluator, not tenant-runtime execution evidence.</summary>

public sealed class ConfigurationVerificationIdentity
{
    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("planSha256")]
    [JsonRequired]
    public string PlanSha256 { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("desiredBundleSha256")]
    [JsonRequired]
    public string DesiredBundleSha256 { get; set; } = default!;

    /// <summary>Exact workspace snapshot used to plan.</summary>
    [JsonPropertyName("baseSnapshotEtag")]
    [JsonRequired]
    public string BaseSnapshotEtag { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("evaluatorSha256")]
    [JsonRequired]
    public string EvaluatorSha256 { get; set; } = default!;

    /// <summary>All desired mappings containing saved cases, sorted by resource key.</summary>
    [JsonPropertyName("mappings")]
    [JsonRequired]
    public List<ConfigurationVerificationMapping> Mappings { get; set; } = default!;

    /// <summary>Desired mappings without saved cases. A passing suite does not cover these mappings.</summary>
    [JsonPropertyName("untestedMappingCount")]
    [JsonRequired]
    public int UntestedMappingCount { get; set; } = default!;

    /// <summary>Total selected saved cases, including cases not reached before cancellation or timeout.</summary>
    [JsonPropertyName("caseCount")]
    [JsonRequired]
    public int CaseCount { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
