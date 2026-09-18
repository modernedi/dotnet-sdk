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

public sealed class ScenarioOperation
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>Opaque operation telemetry. Clients transition from the returned run, ETag, and guidance rather than parsing this value.</summary>
    [JsonPropertyName("action")]
    [JsonRequired]
    public string Action { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("disposition")]
    [JsonRequired]
    public string Disposition { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("fromRevision")]
    [JsonRequired]
    public int FromRevision { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("toRevision")]
    [JsonRequired]
    public int ToRevision { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
