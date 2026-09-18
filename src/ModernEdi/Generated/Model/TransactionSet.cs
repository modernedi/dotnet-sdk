// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>X12 transaction-set identity captured from ST01 and the reference catalog.</summary>

public sealed class TransactionSet
{
    /// <summary>ST01 transaction-set identifier, or &#x60;null&#x60; when the runtime did not record one.</summary>
    [JsonPropertyName("code")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> Code { get; set; }

    /// <summary>Human-readable ST01 document name, or &#x60;null&#x60; when the code is unavailable or unknown.</summary>
    [JsonPropertyName("description")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> Description { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
