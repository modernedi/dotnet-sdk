// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Public half of a ModernEDI AS2 signing/encryption certificate; private keys are never exposed.</summary>

public sealed class As2PublicCertificate
{
    /// <summary>Certificate lifecycle slot: &#x60;active&#x60; is in service and &#x60;next&#x60; is staged for partner-by-partner rollover.</summary>
    [JsonPropertyName("slot")]
    [JsonRequired]
    public string Slot { get; set; } = default!;

    /// <summary>PEM-encoded public certificate safe to share with trading partners.</summary>
    [JsonPropertyName("publicCertPem")]
    [JsonRequired]
    public string PublicCertPem { get; set; } = default!;

    /// <summary>X.509 subject distinguished name, or &#x60;null&#x60; when certificate parsing did not provide it.</summary>
    [JsonPropertyName("subjectDn")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> SubjectDn { get; set; }

    /// <summary>X.509 issuer distinguished name, or &#x60;null&#x60; when certificate parsing did not provide it.</summary>
    [JsonPropertyName("issuerDn")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> IssuerDn { get; set; }

    /// <summary>Certificate serial number rendered for partner correlation, or &#x60;null&#x60; when unavailable.</summary>
    [JsonPropertyName("serialNumber")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> SerialNumber { get; set; }

    /// <summary>SHA-256 certificate fingerprint for out-of-band verification, or &#x60;null&#x60; when unavailable.</summary>
    [JsonPropertyName("fingerprintSha256")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> FingerprintSha256 { get; set; }

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("notBefore")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> NotBefore { get; set; }

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("notAfter")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> NotAfter { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
