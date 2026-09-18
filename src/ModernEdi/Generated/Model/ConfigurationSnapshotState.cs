// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Observed server state stored at &#x60;_state/snapshot.json&#x60;. It relates portable resource keys to current workspace ids, API ETags, and exported resource hashes.</summary>

public sealed class ConfigurationSnapshotState
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    [JsonRequired]
    public string ApiVersion { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary>Monotonic workspace runtime-configuration revision observed by this export transaction.</summary>
    [JsonPropertyName("runtimeConfigurationRevision")]
    [JsonRequired]
    public long RuntimeConfigurationRevision { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("bundleSha256")]
    [JsonRequired]
    public string BundleSha256 { get; set; } = default!;

    /// <summary>Observed resource state sorted by kind and portable key.</summary>
    [JsonPropertyName("resources")]
    [JsonRequired]
    public List<ConfigurationSnapshotResource> Resources { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
