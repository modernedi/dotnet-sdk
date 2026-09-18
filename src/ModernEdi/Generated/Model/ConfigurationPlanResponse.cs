// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Deterministic read-only comparison between one validated desired bundle and the workspace&#39;s current portable AS2, partner, and mapping configuration.</summary>

public sealed class ConfigurationPlanResponse
{
    /// <summary>Always &#x60;true&#x60; when planning completed, including a plan with semantic errors.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary>Whether the desired configuration passed semantic validation and complete scenario-impact analysis and can therefore receive a &#x60;planSha256&#x60;.</summary>
    [JsonPropertyName("applicable")]
    [JsonRequired]
    public bool Applicable { get; set; } = default!;

    /// <summary>SHA-256 of the submitted canonical &#x60;modernedi.json&#x60; manifest.</summary>
    [JsonPropertyName("desiredBundleSha256")]
    [JsonRequired]
    public string DesiredBundleSha256 { get; set; } = default!;

    /// <summary>Strong quoted SHA-256 identity of the current configuration snapshot used for this comparison.</summary>
    [JsonPropertyName("currentSnapshotEtag")]
    [JsonRequired]
    public string CurrentSnapshotEtag { get; set; } = default!;

    /// <summary>Tenant-wide runtime configuration revision observed by the same repeatable-read planning transaction.</summary>
    [JsonPropertyName("runtimeConfigurationRevision")]
    [JsonRequired]
    public long RuntimeConfigurationRevision { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("validationContext")]
    [JsonRequired]
    public ConfigurationPlanValidationContext ValidationContext { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("summary")]
    [JsonRequired]
    public ConfigurationPlanSummary Summary { get; set; } = default!;

    /// <summary>Changed resources only, in deterministic dependency-aware display order. Unchanged resources are counted in &#x60;summary.unchanged&#x60;.</summary>
    [JsonPropertyName("operations")]
    [JsonRequired]
    public List<ConfigurationPlanOperation> Operations { get; set; } = default!;

    /// <summary>Deterministically ordered semantic errors and warnings. Any ERROR makes &#x60;applicable&#x60; false.</summary>
    [JsonPropertyName("diagnostics")]
    [JsonRequired]
    public List<ConfigurationPlanDiagnostic> Diagnostics { get; set; } = default!;

    /// <summary>Whether ModernEDI safely evaluated every applied scenario binding that could depend on a changed resource. False makes &#x60;applicable&#x60; false.</summary>
    [JsonPropertyName("scenarioImpactComplete")]
    [JsonRequired]
    public bool ScenarioImpactComplete { get; set; } = default!;

    /// <summary>Applied scenario bindings that would require reapplication if these operations were later applied.</summary>
    [JsonPropertyName("affectedScenarios")]
    [JsonRequired]
    public List<ConfigurationPlanAffectedScenario> AffectedScenarios { get; set; } = default!;

    /// <summary>ACTIVE scenario runs pinned to affected binding revisions. Any entry makes the plan inapplicable until the run is cancelled or completed and configuration is planned again.</summary>
    [JsonPropertyName("affectedRuns")]
    [JsonRequired]
    public List<ConfigurationPlanAffectedRun> AffectedRuns { get; set; } = default!;

    /// <summary>Deterministic identity binding desired state, current snapshot, validation context, operations, and scenario impact. Null when &#x60;applicable&#x60; is false.</summary>
    [JsonPropertyName("planSha256")]
    [JsonRequired]
    public string? PlanSha256 { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
