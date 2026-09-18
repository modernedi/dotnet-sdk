// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Customer-defined searchable transaction identifier used for reconciliation.</summary>

public sealed class TransactionBusinessKey
{
    /// <summary>Stable customer-facing identifier label, or &#x60;null&#x60; for older records that stored only a value.</summary>
    [JsonPropertyName("name")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> Name { get; set; }

    /// <summary>Extracted or caller-supplied scalar identifier value stored as text.</summary>
    [JsonPropertyName("value")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> Value { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
