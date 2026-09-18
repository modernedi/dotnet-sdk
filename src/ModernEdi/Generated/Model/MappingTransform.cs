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

public sealed class MappingTransform
{
    /// <summary>Transform runtime selected by mapping direction. Incoming mappings use &#x60;X12_MAPPER&#x60;; outgoing mappings use &#x60;XSLT&#x60; or &#x60;JSLT&#x60;.</summary>
    [JsonPropertyName("type")]
    [JsonRequired]
    public string Type { get; set; } = default!;

    /// <summary>Source-controlled transform filename shown in the workspace and transaction provenance.</summary>
    [JsonPropertyName("fileName")]
    [JsonRequired]
    public string FileName { get; set; } = default!;

    /// <summary>Complete map source text, limited to 524,288 characters (512 KiB) by the executable mapping runtime. This value is returned on reads for configuration-as-code workflows.</summary>
    [JsonPropertyName("source")]
    [JsonRequired]
    public string Source { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
