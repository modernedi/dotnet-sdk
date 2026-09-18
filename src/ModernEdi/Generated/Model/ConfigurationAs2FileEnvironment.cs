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

public sealed class ConfigurationAs2FileEnvironment
{
    /// <summary></summary>
    [JsonPropertyName("as2Identifier")]
    [JsonRequired]
    public string As2Identifier { get; set; } = default!;

    /// <summary>Relative to connection.json. Production and Test may reference the same file. The file name uses 1-64 lowercase letters, digits, hyphens or underscores and starts with a letter or digit. No absolute paths, URLs, traversal, subdirectories, or other connections. Exports use shared.pem when both environments have the same certificate; otherwise production.pem and test.pem.</summary>
    [JsonPropertyName("publicCertificatePath")]
    [JsonRequired]
    public string PublicCertificatePath { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("publicCertificateSha256")]
    [JsonRequired]
    public string PublicCertificateSha256 { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("requireSignature")]
    [JsonRequired]
    public bool RequireSignature { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("requireEncryption")]
    [JsonRequired]
    public bool RequireEncryption { get; set; } = default!;

    /// <summary>The same publicly routable destination and workspace plan restrictions as the partner form apply.</summary>
    [JsonPropertyName("endpointUrl")]
    [JsonRequired]
    public string? EndpointUrl { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
