// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Mapping identity and revision comparison recorded with a transaction&#39;s persisted output.</summary>

public sealed class TransactionMappedOutputMapping
{
    /// <summary>Whether the producing source is current, changed, missing, or cannot be compared.</summary>
    [JsonPropertyName("versionStatus")]
    [JsonRequired]
    public string VersionStatus { get; set; } = default!;

    /// <summary>Workspace-scoped mapping id, or &#x60;null&#x60; when historical provenance is incomplete.</summary>
    [JsonPropertyName("id")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int?> Id { get; set; }

    /// <summary>Runtime mapping implementation name, or &#x60;null&#x60; when historical provenance is incomplete.</summary>
    [JsonPropertyName("type")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> Type { get; set; }

    /// <summary>Transform filename used to create the output, or &#x60;null&#x60; when not recorded.</summary>
    [JsonPropertyName("file")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> File { get; set; }

    /// <summary>Base64-encoded SHA-256 hash of the map file used when the inbound output was produced.</summary>
    [JsonPropertyName("fileSha256Hash")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> FileSha256Hash { get; set; }

    /// <summary>Base64-encoded SHA-256 hash of the currently published map file, when it can be resolved.</summary>
    [JsonPropertyName("currentFileSha256Hash")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> CurrentFileSha256Hash { get; set; }

    /// <summary>Immutable grammar-catalog revision declared by the producing mapping execution; &#x60;null&#x60; for legacy records.</summary>
    [JsonPropertyName("syntaxTreeCatalogRevision")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> SyntaxTreeCatalogRevision { get; set; }

    /// <summary>SHA-256 of the exact transaction-set grammar bytes used by the producing mapping execution; &#x60;null&#x60; for legacy records.</summary>
    [JsonPropertyName("syntaxTreeSha256")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> SyntaxTreeSha256 { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
