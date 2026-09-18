// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Published mapping configuration without its database id, API ETag, or server-resolved syntax-tree provenance. The partner reference and source reference are portable bundle values.</summary>

public sealed class ConfigurationMappingSpec
{
    /// <summary>Portable key of the partner resource this mapping handles.</summary>
    [JsonPropertyName("partnerKey")]
    [JsonRequired]
    public string PartnerKey { get; set; } = default!;

    /// <summary></summary>
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
    public ConfigurationMappingTransform Transform { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("output")]
    [JsonRequired]
    public ConfigurationMappingOutput Output { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("runtime")]
    [JsonRequired]
    public ConfigurationMappingRuntime Runtime { get; set; } = default!;

    /// <summary>Optional saved editor tests. Omit when empty; sort by unique case id. The canonical JSON array must fit within 256 KiB. Fixtures enter configuration and Git history, so use sanitized sample data. Editing only these cases does not change the live mapping or refresh scenario bindings. Stored cases do not assert a passing result and do not gate apply. </summary>
    [JsonPropertyName("regressionCases")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<List<MappingRegressionCase>> RegressionCases { get; set; }

    /// <summary></summary>
    [JsonPropertyName("businessKey")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<MappingBusinessKey> BusinessKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deliveredMetadata")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<MappingDeliveredMetadata> DeliveredMetadata { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
