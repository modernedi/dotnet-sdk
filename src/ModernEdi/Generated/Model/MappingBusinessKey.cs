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

public sealed class MappingBusinessKey
{
    /// <summary>Stable customer-facing label for the extracted value, such as &#x60;purchaseOrderNumber&#x60;.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    /// <summary>Incoming X12 mapper expression used to persist the searchable business-key value.</summary>
    [JsonPropertyName("extractor")]
    [JsonRequired]
    public string Extractor { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
