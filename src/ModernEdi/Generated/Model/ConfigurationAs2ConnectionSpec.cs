// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Complete resolved AS2 configuration without its server database id or API ETag. Exports reference public partner certificates beside connection.json. Inline public certificates are also accepted for API-authored and retained historical bundles. Private keys and secret locations are never included.</summary>

public sealed class ConfigurationAs2ConnectionSpec
{
    /// <summary></summary>
    [JsonPropertyName("environments")]
    [JsonRequired]
    public ConfigurationAs2Environments Environments { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("outbound")]
    [JsonRequired]
    public As2ResolvedOutboundSettings Outbound { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("functionalAcknowledgment")]
    [JsonRequired]
    public As2ResolvedFunctionalAcknowledgmentSettings FunctionalAcknowledgment { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("mdn")]
    [JsonRequired]
    public As2ResolvedMdnSettings Mdn { get; set; } = default!;

    /// <summary>Effective RFC 6211 &#x60;cmsAlgorithmProtect&#x60; compatibility setting.</summary>
    [JsonPropertyName("cmsAlgorithmProtection")]
    [JsonRequired]
    public bool CmsAlgorithmProtection { get; set; } = default!;

    /// <summary>Effective inbound signature-verification treatment of MIME line endings.</summary>
    [JsonPropertyName("digestCanonicalizationPolicy")]
    [JsonRequired]
    public string DigestCanonicalizationPolicy { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
