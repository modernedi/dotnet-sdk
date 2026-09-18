// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Atomic confirmation that every requested mapped-output lease was acknowledged.</summary>

public sealed class MappedOutputBulkAckResponse
{
    /// <summary>Always &#x60;true&#x60;; if any lease is invalid the entire request fails and no output is acknowledged.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary>Selects the isolated transaction history containing the original transaction. Defaults to &#x60;production&#x60; when omitted.</summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary>Number of outputs acknowledged by this atomic batch.</summary>
    [JsonPropertyName("acknowledgedCount")]
    [JsonRequired]
    public int AcknowledgedCount { get; set; } = default!;

    /// <summary>Canonical acknowledgment records in the same successful batch.</summary>
    [JsonPropertyName("acknowledgments")]
    [JsonRequired]
    public List<MappedOutputAcknowledgment> Acknowledgments { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
