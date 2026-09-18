// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>A named completion event emitted by exactly one checkpoint pipeline stage after its preceding stages finish. For example, an X12 301 booking-confirmation step can emit bookingDisposition after exchange and fact extraction, allowing the run to choose the cancellation or shipping-instructions path.</summary>

public sealed class ConfigurationScenarioDefinitionCheckpoint
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
