// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Optional untrusted snapshot copied from configuration export. It is accepted only with the canonical path, role, and JSON representation. ModernEDI compares its digest with current state to report &#x60;BASE_SNAPSHOT_STALE&#x60;, but never trusts its database ids, ETags, revision, or resource inventory as mutation authority.</summary>

public sealed class ConfigurationPlanAdvisoryStateFile
{
    /// <summary></summary>
    [JsonPropertyName("path")]
    [JsonRequired]
    public string Path { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("role")]
    [JsonRequired]
    public string Role { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("format")]
    [JsonRequired]
    public string Format { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("mediaType")]
    [JsonRequired]
    public string MediaType { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("contentSha256")]
    [JsonRequired]
    public string ContentSha256 { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("content")]
    [JsonRequired]
    public ConfigurationSnapshotState Content { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
