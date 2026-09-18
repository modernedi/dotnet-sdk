// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Public signing/encryption certificates ModernEDI may present for this workspace.</summary>

public sealed class As2ProfileCertificates
{
    /// <summary>Current certificate to configure at partners, or &#x60;null&#x60; before certificate provisioning completes.</summary>
    [JsonPropertyName("active")]
    [JsonRequired]
    public As2PublicCertificate? Active { get; set; } = default!;

    /// <summary>Staged rollover certificate, or &#x60;null&#x60; when no certificate rotation is in progress.</summary>
    [JsonPropertyName("next")]
    [JsonRequired]
    public As2PublicCertificate? Next { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
