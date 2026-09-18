// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Complete persisted AS2 connection returned by configuration operations.</summary>

public sealed class As2ConnectionConfiguration
{
    /// <summary>Stable workspace-scoped identifier used when attaching partners or updating this connection.</summary>
    [JsonPropertyName("connectionId")]
    [JsonRequired]
    public int ConnectionId { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environments")]
    [JsonRequired]
    public As2ConnectionResolvedEnvironments Environments { get; set; } = default!;

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

    /// <summary>Effective RFC 6211 &#x60;cmsAlgorithmProtect&#x60; compatibility setting for signed outbound messages and MDNs.</summary>
    [JsonPropertyName("cmsAlgorithmProtection")]
    [JsonRequired]
    public bool CmsAlgorithmProtection { get; set; } = default!;

    /// <summary>Effective inbound signature-verification treatment of MIME line endings.</summary>
    [JsonPropertyName("digestCanonicalizationPolicy")]
    [JsonRequired]
    public string DigestCanonicalizationPolicy { get; set; } = default!;

    /// <summary>Quoted SHA-256 identity of the observed AS2 connection configuration. Changes use the aggregate export–plan–apply workflow.</summary>
    [JsonPropertyName("etag")]
    [JsonRequired]
    public string Etag { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
