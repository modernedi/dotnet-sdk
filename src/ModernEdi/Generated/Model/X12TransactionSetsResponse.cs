// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Transaction-set reference catalog for one supported X12 version.</summary>

public sealed class X12TransactionSetsResponse
{
    /// <summary>Always &#x60;true&#x60;; failures use the documented error response instead.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary>Requested numeric X12 version whose catalog is returned.</summary>
    [JsonPropertyName("x12Version")]
    [JsonRequired]
    public string X12Version { get; set; } = default!;

    /// <summary>Supported transaction-set identifiers and their customer-readable names.</summary>
    [JsonPropertyName("transactionSets")]
    [JsonRequired]
    public List<X12TransactionSetReference> TransactionSets { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
