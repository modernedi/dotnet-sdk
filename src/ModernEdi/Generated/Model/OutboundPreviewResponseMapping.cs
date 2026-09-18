// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Published outgoing map selected from the partner, content type, X12 version, and request route.</summary>

public sealed class OutboundPreviewResponseMapping
{
    /// <summary>Stable workspace-scoped identifier of the selected outgoing map.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public int Id { get; set; } = default!;

    /// <summary>Transform engine used by the published map, such as &#x60;xslt&#x60; or &#x60;jslt&#x60;.</summary>
    [JsonPropertyName("transformType")]
    [JsonRequired]
    public string TransformType { get; set; } = default!;

    /// <summary>Customer-visible transform filename recorded for the selected map.</summary>
    [JsonPropertyName("file")]
    [JsonRequired]
    public string File { get; set; } = default!;

    /// <summary>Base64-encoded SHA-256 hash of the published map contents.</summary>
    [JsonPropertyName("fileSha256Hash")]
    [JsonRequired]
    public string FileSha256Hash { get; set; } = default!;

    /// <summary>Source media type expected by the selected outgoing map.</summary>
    [JsonPropertyName("contentType")]
    [JsonRequired]
    public string ContentType { get; set; } = default!;

    /// <summary>X12 version the selected map generates.</summary>
    [JsonPropertyName("x12Version")]
    [JsonRequired]
    public string X12Version { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
