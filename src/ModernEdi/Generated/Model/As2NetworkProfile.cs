// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Current tenant-runtime network and certificate provisioning state.</summary>

public sealed class As2NetworkProfile
{
    /// <summary></summary>
    [JsonPropertyName("staticInbound")]
    [JsonRequired]
    public As2NetworkCapability StaticInbound { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("staticOutbound")]
    [JsonRequired]
    public As2NetworkCapability StaticOutbound { get; set; } = default!;

    /// <summary>Latest tenant-runtime provisioning state, or &#x60;null&#x60; before a status has been recorded.</summary>
    [JsonPropertyName("provisioningStatus")]
    [JsonRequired]
    public string? ProvisioningStatus { get; set; } = default!;

    /// <summary>Latest TLS certificate deployment state for the AS2 hostname, or &#x60;null&#x60; when unavailable.</summary>
    [JsonPropertyName("tlsCertificateStatus")]
    [JsonRequired]
    public string? TlsCertificateStatus { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
