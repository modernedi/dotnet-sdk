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

public sealed class As2PartnerEnvironment
{
    /// <summary>Partner&#39;s environment-specific AS2 identifier. ModernEDI matches it as inbound &#x60;AS2-From&#x60; and sends it as outbound &#x60;AS2-To&#x60;.</summary>
    [JsonPropertyName("as2Identifier")]
    [JsonRequired]
    public string As2Identifier { get; set; } = default!;

    /// <summary>Exactly one PEM-encoded partner X.509 public certificate. ModernEDI canonicalizes it before storage.</summary>
    [JsonPropertyName("publicCertificatePem")]
    [JsonRequired]
    public string PublicCertificatePem { get; set; } = default!;

    /// <summary>Optional outbound destination. Omit it or use &#x60;null&#x60; for an inbound-only profile. When present, it must be an absolute HTTP or HTTPS partner destination URL without user information or a fragment. Endpoint workspaces must use HTTPS; plain HTTP requires Endpoint Plus, Static Outbound, Static Network, or Enterprise. The host must be publicly routable; local, private, link-local, multicast, carrier-grade NAT, documentation, benchmark, and other reserved address targets are rejected.</summary>
    [JsonPropertyName("endpointUrl")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> EndpointUrl { get; set; }

    /// <summary>When &#x60;true&#x60; (the secure default), ModernEDI rejects non-MDN inbound messages for this environment unless the sender signature is present and successfully verified with the configured certificate. This policy belongs to the AS2 connection/environment and therefore applies to every attached partner on a shared or VAN connection. Set &#x60;false&#x60; only for a documented connection-wide exception. Omission on create resolves to &#x60;true&#x60;; resolved connection responses always include the field.</summary>
    [JsonPropertyName("requireSignature")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> RequireSignature { get; set; }

    /// <summary>When &#x60;true&#x60; (the secure default), ModernEDI rejects non-MDN inbound messages for this environment unless their encrypted content was successfully decrypted. This policy belongs to the AS2 connection/environment and therefore applies to every attached partner on a shared or VAN connection. Set &#x60;false&#x60; only for a documented connection-wide exception. Omission on create resolves to &#x60;true&#x60;; resolved connection responses always include the field.</summary>
    [JsonPropertyName("requireEncryption")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> RequireEncryption { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
