// Generated from the ModernEDI Integration API 1.36.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Durable bounded suite. Results expire after 90 days; only the most recent 200 workspace runs are retained. Freshness is checked on reads.</summary>

public sealed class ConfigurationVerificationRun
{
    /// <summary>Server-owned verification run identity.</summary>
    [JsonPropertyName("runId")]
    [JsonRequired]
    public string RunId { get; set; } = default!;

    /// <summary>PASSED covers the selected mapping and offline conversation expectations; it does not establish delivery, partner acceptance or a successful live scenario run.</summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Server admission time.</summary>
    [JsonPropertyName("createdAt")]
    [JsonRequired]
    public string CreatedAt { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("identity")]
    [JsonRequired]
    public ConfigurationVerificationIdentity Identity { get; set; } = default!;

    /// <summary>Completed case outcomes. Incomplete suites cannot pass.</summary>
    [JsonPropertyName("cases")]
    [JsonRequired]
    public List<ConfigurationVerificationRunCasesInner> Cases { get; set; } = default!;

    /// <summary>Whether current workspace, evaluator and catalog still match this result.</summary>
    [JsonPropertyName("freshness")]
    [JsonRequired]
    public string Freshness { get; set; } = default!;

    /// <summary>Empty only when current.</summary>
    [JsonPropertyName("staleReasons")]
    [JsonRequired]
    public List<string> StaleReasons { get; set; } = default!;

    /// <summary>Server completion time; null while running.</summary>
    [JsonPropertyName("completedAt")]
    [JsonRequired]
    public string? CompletedAt { get; set; } = default!;

    /// <summary>Apply operation explicitly linked to this result, or null.</summary>
    [JsonPropertyName("appliedOperationId")]
    [JsonRequired]
    public string? AppliedOperationId { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
