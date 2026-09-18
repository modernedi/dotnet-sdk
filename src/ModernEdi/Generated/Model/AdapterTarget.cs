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

public sealed class AdapterTarget
{
    /// <summary></summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary>Registered active executor adapter ID. Apply verifies it implements this definition and step.</summary>
    [JsonPropertyName("adapterId")]
    [JsonRequired]
    public string AdapterId { get; set; } = default!;

    /// <summary>Stable Mapping resource key in this configuration bundle; resolved to a workspace ID during apply.</summary>
    [JsonPropertyName("mappingKey")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> MappingKey { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
