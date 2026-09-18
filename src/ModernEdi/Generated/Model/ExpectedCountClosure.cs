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

public sealed class ExpectedCountClosure
{
    /// <summary>Close when the number of occurrences reaches an exact integer supplied by a required run parameter or a declared default. The value must fit this step&#39;s occurrence bounds; steps sharing one count parameter must have overlapping bounds. Example: expectedShipmentCount&#x3D;2 closes a repeated 945 step after two shipping-advice documents.</summary>
    [JsonPropertyName("kind")]
    [JsonRequired]
    public string Kind { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("parameter")]
    [JsonRequired]
    public string Parameter { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
