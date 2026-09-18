// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Published incoming and outgoing mapping capabilities available for one partner.</summary>

public sealed class PartnerCapabilitiesResponse
{
    /// <summary>Always &#x60;true&#x60;; failures use the documented error response instead.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("partner")]
    [JsonRequired]
    public IntegrationPartner Partner { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("capabilities")]
    [JsonRequired]
    public PartnerCapabilitiesResponseCapabilities Capabilities { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
