// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>ModernEDI-hosted AS2 identity and network information for production and test traffic.</summary>

public sealed class As2Profile
{
    /// <summary></summary>
    [JsonPropertyName("environments")]
    [JsonRequired]
    public As2ProfileEnvironments Environments { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("network")]
    [JsonRequired]
    public As2NetworkProfile Network { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("certificates")]
    [JsonRequired]
    public As2ProfileCertificates Certificates { get; set; } = default!;

    /// <summary>Provisioned tenant AS2 hostname, or &#x60;null&#x60; while the tenant runtime has not published one.</summary>
    [JsonPropertyName("domainName")]
    [JsonRequired]
    public string? DomainName { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
