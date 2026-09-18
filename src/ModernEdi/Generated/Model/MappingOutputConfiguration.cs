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

public sealed class MappingOutputConfiguration
{
    /// <summary>Mapped payload content type for incoming maps; source content type selected by outgoing maps.</summary>
    [JsonPropertyName("contentType")]
    [JsonRequired]
    public string ContentType { get; set; } = default!;

    /// <summary>Server-selected delivery behavior. New incoming public mappings use &#x60;MAPPED_OUTPUTS&#x60;; outgoing maps use &#x60;OUTBOUND_AS2&#x60;.</summary>
    [JsonPropertyName("delivery")]
    [JsonRequired]
    public string Delivery { get; set; } = default!;

    /// <summary>Defaults to &#x60;PROCESSING&#x60; when omitted. Incoming mappings may also use &#x60;ACKNOWLEDGMENT&#x60;; outgoing mappings use &#x60;PROCESSING&#x60;.</summary>
    [JsonPropertyName("purpose")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> Purpose { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
