// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Only assurances declared by this step are present. Pending evidence can be refreshed by observing the same transaction again with a new command identity.</summary>

public sealed class ScenarioGraphAssurances
{
    /// <summary></summary>
    [JsonPropertyName("mapping_succeeded")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> MappingSucceeded { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transport_receipt_accepted")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> TransportReceiptAccepted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("interchange_acknowledgment_accepted")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> InterchangeAcknowledgmentAccepted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("functional_or_implementation_acknowledgment_accepted")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> FunctionalOrImplementationAcknowledgmentAccepted { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
