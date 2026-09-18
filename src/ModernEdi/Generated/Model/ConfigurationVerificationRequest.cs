// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Execute saved cases from the exact desired configuration under review. Request IDs are replayable only with identical content and the same API key.</summary>

public sealed class ConfigurationVerificationRequest
{
    /// <summary>Persist a canonical UUID and reuse it only when retrying this exact request.</summary>
    [JsonPropertyName("requestId")]
    [JsonRequired]
    public string RequestId { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("planSha256")]
    [JsonRequired]
    public string PlanSha256 { get; set; } = default!;

    /// <summary>Exact logical files from the applicable plan.</summary>
    [JsonPropertyName("files")]
    [JsonRequired]
    public List<ConfigurationPlanFile> Files { get; set; } = default!;

    /// <summary>Optional binding resource keys to re-apply against the destination workspace&#39;s current runtime authority without changing their authored files. Include the same selection in plan and apply. Referenced mapping/partner changes also produce explicit dependent binding updates in the plan. This option is apply metadata and never enters Git files.</summary>
    [JsonPropertyName("refreshScenarioBindings")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<List<string>> RefreshScenarioBindings { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
