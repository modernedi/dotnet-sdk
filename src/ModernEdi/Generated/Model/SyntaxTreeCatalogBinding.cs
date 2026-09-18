// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Content-addressed identifiers for the exact X12 grammar used to validate and execute a mapping. These values support reproducibility and diagnostics and do not expose internal storage locations. </summary>

public sealed class SyntaxTreeCatalogBinding
{
    /// <summary>Version of this catalog-binding metadata contract, used by clients to interpret the immutable grammar identifiers safely.</summary>
    [JsonPropertyName("schemaVersion")]
    [JsonRequired]
    public string SchemaVersion { get; set; } = default!;

    /// <summary>SHA-256 identity of the complete immutable syntax-tree catalog at approval time. This approval revision can differ from a later active platform catalog when syntaxTreeSha256 proves that the exact grammar for this mapping&#39;s X12 version and transaction set is unchanged. </summary>
    [JsonPropertyName("catalogRevision")]
    [JsonRequired]
    public string CatalogRevision { get; set; } = default!;

    /// <summary>SHA-256 of the canonical catalog manifest.</summary>
    [JsonPropertyName("manifestSha256")]
    [JsonRequired]
    public string ManifestSha256 { get; set; } = default!;

    /// <summary>SHA-256 of the exact normalized grammar bytes for this X12 version and transaction set.</summary>
    [JsonPropertyName("syntaxTreeSha256")]
    [JsonRequired]
    public string SyntaxTreeSha256 { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
