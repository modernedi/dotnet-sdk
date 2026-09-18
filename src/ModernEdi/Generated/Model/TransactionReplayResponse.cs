// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Atomic response-only replay result using the mappings currently published for the partner.</summary>

public sealed class TransactionReplayResponse
{
    /// <summary>Always &#x60;true&#x60;; replay validation or execution failures use the replay error response.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("replay")]
    [JsonRequired]
    public TransactionReplay Replay { get; set; } = default!;

    /// <summary>Newly generated map results. They are not enqueued and do not trigger mapped-output webhooks.</summary>
    [JsonPropertyName("regeneratedOutputs")]
    [JsonRequired]
    public List<TransactionMappedOutput> RegeneratedOutputs { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
