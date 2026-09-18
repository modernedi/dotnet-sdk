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

public sealed class ScenarioEvidenceBinding
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("revision")]
    [JsonRequired]
    public long Revision { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("snapshotContentSha256")]
    [JsonRequired]
    public string SnapshotContentSha256 { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("definitionContentSha256")]
    [JsonRequired]
    public string DefinitionContentSha256 { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("adapterId")]
    [JsonRequired]
    public string AdapterId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("authority")]
    [JsonRequired]
    public ScenarioEvidenceAuthority Authority { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
