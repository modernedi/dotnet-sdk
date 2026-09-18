// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Fully resolved outbound algorithms and compatibility settings; all fields are present in responses.</summary>

public sealed class As2ResolvedOutboundSettings
{
    /// <summary>CMS/S/MIME signature algorithm ModernEDI uses for signed outbound payloads, signed automatic X12 acknowledgments, and signed MDNs. Prefer &#x60;SHA256WITHRSA&#x60;; use &#x60;SHA1WITHRSA&#x60; only for a legacy partner that cannot verify SHA-2 signatures.</summary>
    [JsonPropertyName("signingAlgorithm")]
    [JsonRequired]
    public string SigningAlgorithm { get; set; } = default!;

    /// <summary>CMS content-encryption algorithm for outbound AS2 payloads and any encrypted acknowledgments. Prefer &#x60;AES256_CBC&#x60;; &#x60;DES_EDE3_CBC&#x60; exists only for legacy partner interoperability.</summary>
    [JsonPropertyName("encryptionAlgorithm")]
    [JsonRequired]
    public string EncryptionAlgorithm { get; set; } = default!;

    /// <summary>Compression algorithm used when an outbound AS2 message structure includes compression. &#x60;ZLIB&#x60; is the only supported customer-selectable value.</summary>
    [JsonPropertyName("compressionAlgorithm")]
    [JsonRequired]
    public string CompressionAlgorithm { get; set; } = default!;

    /// <summary>Digest algorithm used to calculate and store ModernEDI&#39;s local content MIC for outbound X12 payloads and automatic X12 acknowledgments. This does not choose the CMS signature digest (&#x60;signingAlgorithm&#x60; does), the signed MIME &#x60;micalg&#x60; token format (&#x60;micAlgorithmFormat&#x60; does), or the &#x60;Received-content-MIC&#x60; algorithm used when ModernEDI returns an MDN for an inbound message; that comes from the sender&#39;s receipt request.</summary>
    [JsonPropertyName("micAlgorithm")]
    [JsonRequired]
    public string MicAlgorithm { get; set; } = default!;

    /// <summary>Advanced partner-compatibility override for the S/MIME &#x60;Content-Type&#x60; &#x60;micalg&#x60; parameter on every signed MIME entity ModernEDI generates for this partner, including outbound X12 messages, automatic signed X12 acknowledgments, and the outer wrapper of signed MDNs. &#x60;RFC_5751&#x60; uses the newer hyphenated token format—for example, &#x60;sha-256&#x60;—while &#x60;RFC_3851&#x60; uses the older token &#x60;sha256&#x60;. Omit this field to use the compatibility-first &#x60;RFC_3851&#x60; default. This setting changes only the serialized notation of the signature digest selected by &#x60;signingAlgorithm&#x60; in that MIME parameter; it does not change the digest itself or the algorithm named inside &#x60;Received-content-MIC&#x60;. Change it only when the partner&#39;s AS2 profile or interoperability testing requires a particular token format.</summary>
    [JsonPropertyName("micAlgorithmFormat")]
    [JsonRequired]
    public string MicAlgorithmFormat { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
