// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Exact stored X12 grammar and catalog frozen for this mapping.</summary>

public sealed class ConfigurationVerificationSyntaxTree
{
    /// <summary>Syntax-tree catalog identity format.</summary>
    [JsonPropertyName("schemaVersion")]
    [JsonRequired]
    public string SchemaVersion { get; set; } = default!;

    /// <summary>X12 release of the stored grammar.</summary>
    [JsonPropertyName("x12Version")]
    [JsonRequired]
    public string X12Version { get; set; } = default!;

    /// <summary>X12 transaction set of the stored grammar.</summary>
    [JsonPropertyName("transactionSetIdentifierCode")]
    [JsonRequired]
    public string TransactionSetIdentifierCode { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("catalogRevision")]
    [JsonRequired]
    public string CatalogRevision { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("manifestSha256")]
    [JsonRequired]
    public string ManifestSha256 { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("syntaxTreeSha256")]
    [JsonRequired]
    public string SyntaxTreeSha256 { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
