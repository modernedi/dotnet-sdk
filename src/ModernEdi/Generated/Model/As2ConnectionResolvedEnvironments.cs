// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Fully resolved partner environments. Every non-null environment includes its effective inbound signature and encryption requirements.</summary>

public sealed class As2ConnectionResolvedEnvironments
{
    /// <summary></summary>
    [JsonPropertyName("production")]
    [JsonRequired]
    public As2PartnerEnvironmentResolved Production { get; set; } = default!;

    /// <summary>Fully resolved test environment, or &#x60;null&#x60; when no test profile is configured.</summary>
    [JsonPropertyName("test")]
    [JsonRequired]
    public As2PartnerEnvironmentResolved? Test { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
