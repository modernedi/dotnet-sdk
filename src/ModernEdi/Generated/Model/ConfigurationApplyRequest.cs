// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Exact applicable desired bundle and deterministic plan identity submitted for one aggregate configuration deployment. The files must be byte-for-byte and logically identical to those planned.</summary>

public sealed class ConfigurationApplyRequest
{
    /// <summary>Non-null deterministic plan identity returned by the immediately preceding applicable plan.</summary>
    [JsonPropertyName("planSha256")]
    [JsonRequired]
    public string PlanSha256 { get; set; } = default!;

    /// <summary>The exact desired logical files used to compute &#x60;planSha256&#x60;, optionally including the one canonical advisory &#x60;_state/snapshot.json&#x60; file accepted by planning.</summary>
    [JsonPropertyName("files")]
    [JsonRequired]
    public List<ConfigurationPlanFile> Files { get; set; } = default!;

    /// <summary>Optional binding resource keys to re-apply against the destination workspace&#39;s current runtime authority without changing their authored files. Include the same selection in plan and apply. Referenced mapping/partner changes also produce explicit dependent binding updates in the plan. This option is apply metadata and never enters Git files.</summary>
    [JsonPropertyName("refreshScenarioBindings")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<List<string>> RefreshScenarioBindings { get; set; }

    /// <summary>Optional explicit passing-evidence requirement. When supplied, the server requires a current, unapplied PASSED run for this exact bundle and plan, and links it to the apply atomically. Omit to apply without a verification gate.</summary>
    [JsonPropertyName("verificationRunId")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> VerificationRunId { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
