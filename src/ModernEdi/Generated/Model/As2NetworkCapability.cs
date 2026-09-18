// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Availability and advertised addresses for one static-network capability.</summary>

public sealed class As2NetworkCapability
{
    /// <summary>&#x60;ready&#x60; means addresses may be allowlisted, &#x60;pending&#x60; means provisioning is incomplete, and &#x60;not_included&#x60; means the plan does not include the capability.</summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Public IP addresses to give the partner; empty until ready or when the capability is not included.</summary>
    [JsonPropertyName("addresses")]
    [JsonRequired]
    public List<string> Addresses { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
