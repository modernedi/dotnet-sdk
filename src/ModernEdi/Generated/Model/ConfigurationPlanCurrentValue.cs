// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Observed current identity for an UPDATE or DELETE operation.</summary>

public sealed class ConfigurationPlanCurrentValue
{
    /// <summary>Current tenant-scoped API resource id. Portable references continue to use &#x60;key&#x60;.</summary>
    [JsonPropertyName("resourceId")]
    [JsonRequired]
    public long ResourceId { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("contentSha256")]
    [JsonRequired]
    public string ContentSha256 { get; set; } = default!;

    /// <summary>Current public configuration ETag observed in the same snapshot.</summary>
    [JsonPropertyName("apiEtag")]
    [JsonRequired]
    public string ApiEtag { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
