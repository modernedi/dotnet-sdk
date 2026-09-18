// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One observable proof required for a step. For example, mapping_succeeded proves that the selected map ran, while functional_or_implementation_acknowledgment_accepted proves accepted 997 or 999 evidence. Outgoing mapping proof may predate the document occurrence because mapping runs immediately before exchange; receipts and acknowledgments may not. A deadline is measured from the document occurrence to the terminal evidence time, and requires that evidence&#39;s own timestamp. Terminal evidence timestamped after the run&#39;s evaluation time is invalid.</summary>

public sealed class ConfigurationScenarioDefinitionAssuranceRequirement
{
    /// <summary>mapping_succeeded proves mapper execution; transport_receipt_accepted proves the AS2 receipt; interchange_acknowledgment_accepted proves TA1 acceptance; functional_or_implementation_acknowledgment_accepted proves accepted 997 or 999 evidence.</summary>
    [JsonPropertyName("type")]
    [JsonRequired]
    public string Type { get; set; } = default!;

    /// <summary>A positive ISO 8601 duration accepted by java.time.Duration, no longer than P365D. Examples: PT30M, PT4H, P2D. The server enforces the upper bound.</summary>
    [JsonPropertyName("within")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> Within { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
