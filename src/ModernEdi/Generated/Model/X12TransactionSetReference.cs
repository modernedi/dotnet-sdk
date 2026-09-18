// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One transaction-set identifier in an X12 version&#39;s reference catalog.</summary>

public sealed class X12TransactionSetReference
{
    /// <summary>ST01 transaction-set identifier accepted for this X12 version.</summary>
    [JsonPropertyName("transactionSetIdentifierCode")]
    [JsonRequired]
    public string TransactionSetIdentifierCode { get; set; } = default!;

    /// <summary>Human-readable business-document name associated with the ST01 code.</summary>
    [JsonPropertyName("transactionSetDescription")]
    [JsonRequired]
    public string TransactionSetDescription { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
