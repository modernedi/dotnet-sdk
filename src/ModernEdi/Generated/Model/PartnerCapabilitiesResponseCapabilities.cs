// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Published maps grouped by the direction in which data crosses the partner boundary.</summary>

public sealed class PartnerCapabilitiesResponseCapabilities
{
    /// <summary>Maps that transform inbound partner X12 into application-facing mapped outputs.</summary>
    [JsonPropertyName("incoming")]
    [JsonRequired]
    public List<PartnerMappingCapability> Incoming { get; set; } = default!;

    /// <summary>Maps that transform application payloads into outbound partner X12.</summary>
    [JsonPropertyName("outgoing")]
    [JsonRequired]
    public List<PartnerMappingCapability> Outgoing { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
