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

public sealed class MappingConfigurationRevisionDetail
{
    /// <summary>Immutable id for this stored mapping-configuration revision.</summary>
    [JsonPropertyName("revisionId")]
    [JsonRequired]
    public int RevisionId { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;.</summary>
    [JsonPropertyName("createdAt")]
    [JsonRequired]
    public string CreatedAt { get; set; } = default!;

    /// <summary>Base64-encoded SHA-256 hash of the transform source text. This identifies source content; it is not a concurrency-control ETag.</summary>
    [JsonPropertyName("sourceHash")]
    [JsonRequired]
    public string SourceHash { get; set; } = default!;

    /// <summary>Whether this exact mapping configuration is currently published. Source text alone is insufficient to make a revision current.</summary>
    [JsonPropertyName("current")]
    [JsonRequired]
    public bool Current { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("transform")]
    [JsonRequired]
    public MappingConfigurationRevisionTransformDetail Transform { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 identity of the complete immutable mapping configuration, or &#x60;null&#x60; for a legacy revision written before exact configuration identities were recorded.</summary>
    [JsonPropertyName("configurationSha256")]
    [JsonRequired]
    public string? ConfigurationSha256 { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("syntaxTreeCatalog")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<SyntaxTreeCatalogBinding> SyntaxTreeCatalog { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
