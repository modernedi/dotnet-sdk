// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Durable receipt record proving when your integration acknowledged one mapped output version.</summary>

public sealed class MappedOutputAcknowledgment
{
    /// <summary>Stable generated-output version id that was acknowledged.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>Original inbound AS2 message id associated with the acknowledged output.</summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string MessageId { get; set; } = default!;

    /// <summary>Unique mapped-output key within the source transaction.</summary>
    [JsonPropertyName("mappedOutputKey")]
    [JsonRequired]
    public string MappedOutputKey { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("ackedAt")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> AckedAt { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
