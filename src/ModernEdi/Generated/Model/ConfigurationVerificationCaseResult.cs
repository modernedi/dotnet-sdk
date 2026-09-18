// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Exact text comparison and optional generated-X12 validation outcome. A case fails if either requested check fails. Raw inputs, outputs and engine diagnostic text are never retained.</summary>

public sealed class ConfigurationVerificationCaseResult
{
    /// <summary>Mapping owning this case.</summary>
    [JsonPropertyName("mappingResourceKey")]
    [JsonRequired]
    public string MappingResourceKey { get; set; } = default!;

    /// <summary>Portable case ID.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>Portable case display name.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    /// <summary>Outcome of this executed case.</summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("caseSha256")]
    [JsonRequired]
    public string CaseSha256 { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("expectedOutputSha256")]
    [JsonRequired]
    public string ExpectedOutputSha256 { get; set; } = default!;

    /// <summary>Actual output hash, or null when execution produced no output.</summary>
    [JsonPropertyName("actualOutputSha256")]
    [JsonRequired]
    public string? ActualOutputSha256 { get; set; } = default!;

    /// <summary>Present only when the saved outgoing case requested validateX12. Uses the frozen mapping syntax tree and the same document preparation and validation as outgoing preview/send. A FAILED case may have matching expected/actual hashes when X12 validation failed.</summary>
    [JsonPropertyName("x12ValidationStatus")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> X12ValidationStatus { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
