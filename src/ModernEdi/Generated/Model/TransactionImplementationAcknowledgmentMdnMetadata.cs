// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Message identity and raw disposition of the AS2 MDN attached to a 999.</summary>

public sealed class TransactionImplementationAcknowledgmentMdnMetadata
{
    /// <summary>Message-ID of the MDN attached to the 999.</summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string? MessageId { get; set; } = default!;

    /// <summary>Raw disposition of the MDN attached to the 999.</summary>
    [JsonPropertyName("disposition")]
    [JsonRequired]
    public string? Disposition { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
