// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Portable desired-state bundle submitted for read-only planning. It contains exactly one manifest and every resource and mapping-source file inventoried by that manifest. It may also include at most one advisory STATE file copied directly from configuration export; ModernEDI never treats that file as authority over current workspace state.</summary>

public sealed class ConfigurationPlanRequest
{
    /// <summary>Desired files plus, optionally, the single exported advisory state file. Paths must be safe, case-insensitively unique relative POSIX paths, and each declared hash must match the file&#39;s logical bytes. Only &#x60;_state/snapshot.json&#x60; may use the &#x60;_state&#x60; prefix.</summary>
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
