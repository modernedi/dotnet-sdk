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

public sealed class ScenarioEvidenceFailure
{
    /// <summary></summary>
    [JsonPropertyName("operationId")]
    [JsonRequired]
    public string OperationId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("action")]
    [JsonRequired]
    public string Action { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("expectedRunRevision")]
    [JsonRequired]
    public long ExpectedRunRevision { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("actor")]
    [JsonRequired]
    public ScenarioRunActor Actor { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("requestedAt")]
    [JsonRequired]
    public string RequestedAt { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("completedAt")]
    [JsonRequired]
    public string CompletedAt { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("error")]
    [JsonRequired]
    public ScenarioEvidenceFailureError Error { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
