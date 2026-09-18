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

public sealed class MappedOutputBulkAckRequest
{
    /// <summary>One to 100 mapped-output id and receipt-handle pairs from the selected environment. The batch is atomic; if any pair is invalid, none are acknowledged.</summary>
    [JsonPropertyName("acks")]
    [JsonRequired]
    public List<MappedOutputBulkAckRequestAcksInner> Acks { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
