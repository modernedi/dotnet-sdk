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

public sealed class ScenarioRunSummary
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("revision")]
    [JsonRequired]
    public long Revision { get; set; } = default!;

    /// <summary>Opaque quoted strong ETag for one tenant-scoped run revision. Clients must return the current value unchanged; its fields are not client authority.</summary>
    [JsonPropertyName("etag")]
    [JsonRequired]
    public string Etag { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("binding")]
    [JsonRequired]
    public ScenarioContextBinding Binding { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("definition")]
    [JsonRequired]
    public ScenarioDefinitionIdentity Definition { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("outcome")]
    [JsonRequired]
    public string Outcome { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("phase")]
    [JsonRequired]
    public string Phase { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("startedAt")]
    [JsonRequired]
    public string StartedAt { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("lastUpdatedAt")]
    [JsonRequired]
    public string LastUpdatedAt { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("guidance")]
    [JsonRequired]
    public ScenarioRunSummaryGuidance Guidance { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("completedAt")]
    [JsonRequired]
    public string? CompletedAt { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
