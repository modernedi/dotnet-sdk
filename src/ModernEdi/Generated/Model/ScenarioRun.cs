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

public sealed class ScenarioRun
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    [JsonRequired]
    public string ApiVersion { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>Server-owned run origin. system_managed is reserved for the managed implementation-verification route; tenant_applied identifies an exact tenant-applied binding start.</summary>
    [JsonPropertyName("origin")]
    [JsonRequired]
    public string Origin { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("binding")]
    [JsonRequired]
    public StartScenarioRunRequestBinding Binding { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("definition")]
    [JsonRequired]
    public ScenarioDefinitionIdentity Definition { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("adapterId")]
    [JsonRequired]
    public string AdapterId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("execution")]
    [JsonRequired]
    public ScenarioGraphExecution Execution { get; set; } = default!;

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
    [JsonPropertyName("revision")]
    [JsonRequired]
    public long Revision { get; set; } = default!;

    /// <summary>Opaque quoted strong ETag for one tenant-scoped run revision. Clients must return the current value unchanged; its fields are not client authority.</summary>
    [JsonPropertyName("etag")]
    [JsonRequired]
    public string Etag { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("counts")]
    [JsonRequired]
    public ScenarioGraphCounts Counts { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("retry")]
    [JsonRequired]
    public ScenarioGraphRetry Retry { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("guidance")]
    [JsonRequired]
    public ScenarioGraphGuidance Guidance { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("steps")]
    [JsonRequired]
    public List<ScenarioGraphStep> Steps { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("checks")]
    [JsonRequired]
    public List<ScenarioGraphCheck> Checks { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("startedAt")]
    [JsonRequired]
    public string? StartedAt { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("completedAt")]
    [JsonRequired]
    public string? CompletedAt { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("lastUpdatedAt")]
    [JsonRequired]
    public string? LastUpdatedAt { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
