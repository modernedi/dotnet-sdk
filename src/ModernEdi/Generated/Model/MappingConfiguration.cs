// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Complete published map, transform source, output contract, provenance controls, and concurrency ETag.</summary>

public sealed class MappingConfiguration
{
    /// <summary>Stable workspace-scoped mapping id used for reads, updates, history, and deletion.</summary>
    [JsonPropertyName("mappingId")]
    [JsonRequired]
    public int MappingId { get; set; } = default!;

    /// <summary>Stable workspace-scoped partner id whose X12 traffic this map handles.</summary>
    [JsonPropertyName("partnerId")]
    [JsonRequired]
    public int PartnerId { get; set; } = default!;

    /// <summary>&#x60;INCOMING&#x60; transforms partner X12 to application data; &#x60;OUTGOING&#x60; transforms application data to partner X12.</summary>
    [JsonPropertyName("direction")]
    [JsonRequired]
    public string Direction { get; set; } = default!;

    /// <summary>Normalized X12 version, such as &#x60;4010&#x60;.</summary>
    [JsonPropertyName("x12Version")]
    [JsonRequired]
    public string X12Version { get; set; } = default!;

    /// <summary>X12 GS01 functional identifier enum name.</summary>
    [JsonPropertyName("functionalIdentifierCode")]
    [JsonRequired]
    public string FunctionalIdentifierCode { get; set; } = default!;

    /// <summary>X12 ST01 transaction-set identifier without a leading underscore.</summary>
    [JsonPropertyName("transactionSetIdentifierCode")]
    [JsonRequired]
    public string TransactionSetIdentifierCode { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("transform")]
    [JsonRequired]
    public MappingTransform Transform { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("output")]
    [JsonRequired]
    public MappingOutputConfiguration Output { get; set; } = default!;

    /// <summary>Portable mapping identity used by exported configuration documents and aggregate plan/apply. Unlike the numeric workspace-local &#x60;mappingId&#x60;, this key remains stable when the configuration moves between workspaces.</summary>
    [JsonPropertyName("configurationResourceKey")]
    [JsonRequired]
    public string ConfigurationResourceKey { get; set; } = default!;

    /// <summary>Quoted SHA-256 configuration ETag.</summary>
    [JsonPropertyName("etag")]
    [JsonRequired]
    public string Etag { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("syntaxTreeCatalog")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<SyntaxTreeCatalogBinding> SyntaxTreeCatalog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("businessKey")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<MappingBusinessKey> BusinessKey { get; set; }

    /// <summary>Present only for incoming mappings.</summary>
    [JsonPropertyName("deliveredMetadata")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<MappingDeliveredMetadata> DeliveredMetadata { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
