// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Compact workspace change-history entry; use the operation endpoint for its full change list.</summary>

public sealed class ConfigurationApplyOperationHistoryEntry
{
    /// <summary>Immutable public id formed as &#x60;apply-&#x60; followed by a canonical lowercase UUID.</summary>
    [JsonPropertyName("operationId")]
    [JsonRequired]
    public string OperationId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("changedBy")]
    [JsonRequired]
    public ConfigurationChangedBy ChangedBy { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("desiredBundleSha256")]
    [JsonRequired]
    public string DesiredBundleSha256 { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("planSha256")]
    [JsonRequired]
    public string PlanSha256 { get; set; } = default!;

    /// <summary>Exact successful-plan snapshot ETag supplied in &#x60;If-Match&#x60;.</summary>
    [JsonPropertyName("baseSnapshotEtag")]
    [JsonRequired]
    public string BaseSnapshotEtag { get; set; } = default!;

    /// <summary>Strong quoted SHA-256 identity of the committed post-apply configuration snapshot. It is available in both PENDING and SUCCEEDED operations because PENDING publication occurs only after database commit.</summary>
    [JsonPropertyName("appliedSnapshotEtag")]
    [JsonRequired]
    public string AppliedSnapshotEtag { get; set; } = default!;

    /// <summary>Tenant-wide runtime configuration revision committed by the aggregate database transaction.</summary>
    [JsonPropertyName("runtimeConfigurationRevision")]
    [JsonRequired]
    public long RuntimeConfigurationRevision { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("summary")]
    [JsonRequired]
    public ConfigurationPlanSummary Summary { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("runtimePublication")]
    [JsonRequired]
    public RuntimePublication RuntimePublication { get; set; } = default!;

    /// <summary>UTC instant when ModernEDI first accepted this idempotency key and semantic apply request.</summary>
    [JsonPropertyName("requestedAt")]
    [JsonRequired]
    public string RequestedAt { get; set; } = default!;

    /// <summary>UTC instant when the aggregate database transaction committed.</summary>
    [JsonPropertyName("committedAt")]
    [JsonRequired]
    public string CommittedAt { get; set; } = default!;

    /// <summary>UTC instant when runtime publication reached its terminal state, or null while &#x60;status&#x60; is &#x60;PENDING&#x60;.</summary>
    [JsonPropertyName("completedAt")]
    [JsonRequired]
    public string? CompletedAt { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
