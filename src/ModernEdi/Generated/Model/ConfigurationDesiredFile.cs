// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One portable desired-state file accepted by configuration planning. JSON content is an object; SOURCE and CERTIFICATE content are exact UTF-8 text strings. A CERTIFICATE must contain exactly one public X.509 certificate in canonical PEM and use as2-connections/&lt;key&gt;/certificates/&lt;name&gt;.pem. Names have 1-64 lowercase letters, digits, hyphens or underscores and start with a letter or digit. Production and Test may reference the same file within their connection.</summary>

public sealed class ConfigurationDesiredFile
{
    /// <summary>Safe relative POSIX-style path outside &#x60;_state&#x60;. The sole MANIFEST path is exactly &#x60;modernedi.json&#x60;.</summary>
    [JsonPropertyName("path")]
    [JsonRequired]
    public string Path { get; set; } = default!;

    /// <summary>Desired-file purpose. STATE is deliberately excluded because observed server identity is not portable desired configuration.</summary>
    [JsonPropertyName("role")]
    [JsonRequired]
    public string Role { get; set; } = default!;

    /// <summary>MANIFEST and RESOURCE files use JSON; SOURCE and CERTIFICATE files use TEXT.</summary>
    [JsonPropertyName("format")]
    [JsonRequired]
    public string Format { get; set; } = default!;

    /// <summary>MANIFEST and RESOURCE files use &#x60;application/json&#x60;; SOURCE and CERTIFICATE files use exact UTF-8 text.</summary>
    [JsonPropertyName("mediaType")]
    [JsonRequired]
    public string MediaType { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("contentSha256")]
    [JsonRequired]
    public string ContentSha256 { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("content")]
    [JsonRequired]
    public ConfigurationDesiredFileContent Content { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
