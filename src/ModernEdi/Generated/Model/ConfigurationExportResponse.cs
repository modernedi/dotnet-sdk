// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Deterministic logical file bundle representing the workspace&#39;s current exportable configuration and its observed API state.</summary>

public sealed class ConfigurationExportResponse
{
    /// <summary>Always &#x60;true&#x60;; failures use the documented error response instead.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary>SHA-256 of the canonical &#x60;modernedi.json&#x60; manifest content. This identifies the portable desired-state bundle and excludes &#x60;_state/snapshot.json&#x60;.</summary>
    [JsonPropertyName("bundleSha256")]
    [JsonRequired]
    public string BundleSha256 { get; set; } = default!;

    /// <summary>SHA-256 of the canonical &#x60;_state/snapshot.json&#x60; content, including current database ids and public API ETags.</summary>
    [JsonPropertyName("snapshotSha256")]
    [JsonRequired]
    public string SnapshotSha256 { get; set; } = default!;

    /// <summary>Quoted &#x60;snapshotSha256&#x60;, also returned in the HTTP &#x60;ETag&#x60; header and accepted by &#x60;If-None-Match&#x60;.</summary>
    [JsonPropertyName("snapshotEtag")]
    [JsonRequired]
    public string SnapshotEtag { get; set; } = default!;

    /// <summary>Complete export sorted lexicographically by &#x60;path&#x60;. It contains the desired resource and source files plus &#x60;modernedi.json&#x60; and &#x60;_state/snapshot.json&#x60;.</summary>
    [JsonPropertyName("files")]
    [JsonRequired]
    public List<ConfigurationExportFile> Files { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
