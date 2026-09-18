// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Identity and immutable execution provenance of the published incoming map that generated a queued output.</summary>

public sealed class MappedOutputMapping
{
    /// <summary>Workspace-scoped mapping id, or &#x60;null&#x60; for historical outputs that predate persisted map identity.</summary>
    [JsonPropertyName("id")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int?> Id { get; set; }

    /// <summary>Runtime mapping implementation name, or &#x60;null&#x60; when it was not recorded with an older output.</summary>
    [JsonPropertyName("type")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> Type { get; set; }

    /// <summary>Customer-visible source filename, or &#x60;null&#x60; when unavailable on an older output.</summary>
    [JsonPropertyName("file")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> File { get; set; }

    /// <summary>Base64-encoded SHA-256 hash of the published map contents. Omitted when &#x60;deliveredMetadata.mappingSourceHash&#x60; is &#x60;false&#x60;. </summary>
    [JsonPropertyName("fileSha256Hash")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> FileSha256Hash { get; set; }

    /// <summary>Immutable grammar-catalog revision declared by the mapping execution; omitted for legacy outputs.</summary>
    [JsonPropertyName("syntaxTreeCatalogRevision")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> SyntaxTreeCatalogRevision { get; set; }

    /// <summary>SHA-256 of the exact transaction-set grammar bytes used by the mapping execution; omitted for legacy outputs.</summary>
    [JsonPropertyName("syntaxTreeSha256")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> SyntaxTreeSha256 { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
