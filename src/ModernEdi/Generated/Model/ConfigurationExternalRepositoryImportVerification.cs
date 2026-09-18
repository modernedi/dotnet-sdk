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

public sealed class ConfigurationExternalRepositoryImportVerification
{
    /// <summary></summary>
    [JsonPropertyName("runId")]
    [JsonRequired]
    public string RunId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("repositoryCommitSha")]
    [JsonRequired]
    public string RepositoryCommitSha { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
