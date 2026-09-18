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

public sealed class ConfigurationSnapshotResource
{
    /// <summary></summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary>Stable portable identity from the corresponding resource document.</summary>
    [JsonPropertyName("key")]
    [JsonRequired]
    public string Key { get; set; } = default!;

    /// <summary>Current workspace-scoped database id used by the existing per-resource Integration API endpoints.</summary>
    [JsonPropertyName("resourceId")]
    [JsonRequired]
    public int ResourceId { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("contentSha256")]
    [JsonRequired]
    public string ContentSha256 { get; set; } = default!;

    /// <summary>Current quoted ETag from the corresponding partner, AS2 connection, or mapping API representation.</summary>
    [JsonPropertyName("apiEtag")]
    [JsonRequired]
    public string ApiEtag { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
