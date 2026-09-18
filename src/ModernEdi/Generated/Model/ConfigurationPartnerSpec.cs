// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Complete persisted partner configuration. It replaces &#x60;as2ConnectionId&#x60; with a portable &#x60;as2ConnectionKey&#x60; and includes advanced runtime compatibility settings that participate in workspace configuration.</summary>

public sealed class ConfigurationPartnerSpec
{
    /// <summary>Unique partner display name in this workspace.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("x12")]
    [JsonRequired]
    public ConfigurationPartnerSpecX12 X12 { get; set; } = default!;

    /// <summary>Partner EDI support address, or an empty string when unavailable.</summary>
    [JsonPropertyName("ediSupportEmail")]
    [JsonRequired]
    public string EdiSupportEmail { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("carbonCopyOnly")]
    [JsonRequired]
    public bool CarbonCopyOnly { get; set; } = default!;

    /// <summary>Whether eligible inbound documents receive a 999 instead of a 997.</summary>
    [JsonPropertyName("implementationAcknowledgmentEnabled")]
    [JsonRequired]
    public bool ImplementationAcknowledgmentEnabled { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("unmappedInboundPolicy")]
    [JsonRequired]
    public string UnmappedInboundPolicy { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("signingCertificateSlot")]
    [JsonRequired]
    public string SigningCertificateSlot { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("supportsNewlineAfterSegmentTerminator")]
    [JsonRequired]
    public bool SupportsNewlineAfterSegmentTerminator { get; set; } = default!;

    /// <summary>Closed runtime compatibility map from supported X12 message-type names to GS08 version overrides. An empty object means no overrides.</summary>
    [JsonPropertyName("messageTypeGsVersionOverrides")]
    [JsonRequired]
    public Dictionary<string, string> MessageTypeGsVersionOverrides { get; set; } = default!;

    /// <summary>Portable key of the referenced AS2 connection, or &#x60;null&#x60; for a detached map-authoring draft.</summary>
    [JsonPropertyName("as2ConnectionKey")]
    [JsonRequired]
    public string? As2ConnectionKey { get; set; } = default!;

    /// <summary>Optional AS2 HTTP User-Agent compatibility override.</summary>
    [JsonPropertyName("overrideUserAgentString")]
    [JsonRequired]
    public string? OverrideUserAgentString { get; set; } = default!;

    /// <summary>Optional X12 separator override, or &#x60;null&#x60; to use runtime defaults.</summary>
    [JsonPropertyName("overrideSeparatorSet")]
    [JsonRequired]
    public ConfigurationPartnerSeparatorSet? OverrideSeparatorSet { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
