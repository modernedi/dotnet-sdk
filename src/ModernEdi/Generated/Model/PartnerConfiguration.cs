// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary></summary>

public sealed class PartnerConfiguration
{
    /// <summary>Stable tenant-scoped partner id. Use this value as the &#x60;partnerId&#x60; query parameter for exact outbound map selection.</summary>
    [JsonPropertyName("partnerId")]
    [JsonRequired]
    public int PartnerId { get; set; } = default!;

    /// <summary>Configured partner display name. Use &#x60;partnerId&#x60; for outbound selection.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    /// <summary>True when this partner is attached to an AS2 connection profile. The profile may be inbound-only and therefore is not necessarily ready for outbound delivery.</summary>
    [JsonPropertyName("as2ConnectionConfigured")]
    [JsonRequired]
    public bool As2ConnectionConfigured { get; set; } = default!;

    /// <summary>True when the partner has a complete production AS2 identifier and certificate, destination URL, and X12 identity, so outbound production delivery can be attempted.</summary>
    [JsonPropertyName("productionReady")]
    [JsonRequired]
    public bool ProductionReady { get; set; } = default!;

    /// <summary>True when the partner has a complete test AS2 identifier and certificate, destination URL, and X12 identity, so outbound test delivery can be attempted. False is valid for a production-only or inbound-only partner.</summary>
    [JsonPropertyName("testReady")]
    [JsonRequired]
    public bool TestReady { get; set; } = default!;

    /// <summary>True when the partner is intended only as a carbon-copy recipient in the workspace.</summary>
    [JsonPropertyName("carbonCopyOnly")]
    [JsonRequired]
    public bool CarbonCopyOnly { get; set; } = default!;

    /// <summary>Whether ModernEDI sends X12 999 implementation acknowledgments for this partner&#39;s 005010-and-later documents instead of automatic 997s. Earlier X12 versions continue to receive 997s. Enable this only when the partner requests 999s. A 999 reports X12 syntax and relational validation. It does not indicate semantic or business acceptance, and it is not HIPAA implementation-guide certification. </summary>
    [JsonPropertyName("implementationAcknowledgmentEnabled")]
    [JsonRequired]
    public bool ImplementationAcknowledgmentEnabled { get; set; } = default!;

    /// <summary>Partner EDI support address, or an empty string when one has not been recorded.</summary>
    [JsonPropertyName("ediSupportEmail")]
    [JsonRequired]
    public string EdiSupportEmail { get; set; } = default!;

    /// <summary>Whether inbound transactions without a matching map are rejected from mapped-output delivery or persisted as raw X12.</summary>
    [JsonPropertyName("unmappedInboundPolicy")]
    [JsonRequired]
    public string UnmappedInboundPolicy { get; set; } = default!;

    /// <summary>Tenant certificate slot ModernEDI uses to sign AS2 traffic for this partner.</summary>
    [JsonPropertyName("signingCertificateSlot")]
    [JsonRequired]
    public string SigningCertificateSlot { get; set; } = default!;

    /// <summary>Whether ModernEDI may emit a newline after each X12 segment terminator for this partner.</summary>
    [JsonPropertyName("supportsNewlineAfterSegmentTerminator")]
    [JsonRequired]
    public bool SupportsNewlineAfterSegmentTerminator { get; set; } = default!;

    /// <summary>Map from functional-group type to the exact GS08 version string required by this partner. An empty object uses each map&#39;s normal X12 version.</summary>
    [JsonPropertyName("messageTypeGsVersionOverrides")]
    [JsonRequired]
    public Dictionary<string, string> MessageTypeGsVersionOverrides { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("x12")]
    [JsonRequired]
    public IntegrationPartnerX12 X12 { get; set; } = default!;

    /// <summary>Quoted SHA-256 ETag over mutable partner configuration, present on list and configuration detail responses. Derived &#x60;as2ConnectionConfigured&#x60;, &#x60;productionReady&#x60;, and &#x60;testReady&#x60; values are excluded; changes to the referenced AS2 connection are guarded by that connection&#39;s own ETag.</summary>
    [JsonPropertyName("etag")]
    [JsonRequired]
    public string Etag { get; set; } = default!;

    /// <summary>Tenant-scoped partner AS2 connection id, or &#x60;null&#x60; while connection details are not yet available.</summary>
    [JsonPropertyName("as2ConnectionId")]
    [JsonRequired]
    public int? As2ConnectionId { get; set; } = default!;

    /// <summary>Optional AS2 HTTP User-Agent compatibility override, or &#x60;null&#x60; to use the ModernEDI default.</summary>
    [JsonPropertyName("overrideUserAgentString")]
    [JsonRequired]
    public string? OverrideUserAgentString { get; set; } = default!;

    /// <summary>Optional X12 separator override, or &#x60;null&#x60; to use the separators selected by the mapping runtime.</summary>
    [JsonPropertyName("overrideSeparatorSet")]
    [JsonRequired]
    public ConfigurationPartnerSeparatorSet? OverrideSeparatorSet { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
