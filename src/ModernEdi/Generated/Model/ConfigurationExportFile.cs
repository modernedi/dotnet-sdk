// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One logical file in the configuration export. JSON content is an object; mapping sources and public PEM certificates are exact text strings. Private keys are never included.</summary>

public sealed class ConfigurationExportFile
{
    /// <summary>Safe relative POSIX-style path. Paths never start with &#x60;/&#x60;, contain &#x60;\\\\&#x60;, contain an empty component, or contain a &#x60;..&#x60; component.</summary>
    [JsonPropertyName("path")]
    [JsonRequired]
    public string Path { get; set; } = default!;

    /// <summary>Purpose of the file. &#x60;STATE&#x60; records observed server identity and is not portable desired configuration.</summary>
    [JsonPropertyName("role")]
    [JsonRequired]
    public string Role { get; set; } = default!;

    /// <summary>How to interpret &#x60;content&#x60; and calculate its logical bytes. &#x60;JSON&#x60; uses canonical JSON; &#x60;TEXT&#x60; uses exact UTF-8 text.</summary>
    [JsonPropertyName("format")]
    [JsonRequired]
    public string Format { get; set; } = default!;

    /// <summary>Media type to use if the logical file is materialized.</summary>
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
    public ConfigurationExportFileContent Content { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
