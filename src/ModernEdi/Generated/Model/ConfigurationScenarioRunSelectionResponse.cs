// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Exact run-start selectors for an active authored binding in the specified completed configuration snapshot. This does not attest runtime availability or run success.</summary>

public sealed class ConfigurationScenarioRunSelectionResponse
{
    /// <summary></summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary>The requested apply operation, not a substituted latest operation.</summary>
    [JsonPropertyName("configurationApplyOperationId")]
    [JsonRequired]
    public string ConfigurationApplyOperationId { get; set; } = default!;

    /// <summary>Matches the requested apply&#39;s appliedSnapshotEtag. Not a scenario-run revision ETag.</summary>
    [JsonPropertyName("appliedSnapshotEtag")]
    [JsonRequired]
    public string AppliedSnapshotEtag { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("selection")]
    [JsonRequired]
    public StartScenarioRunRequest Selection { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
