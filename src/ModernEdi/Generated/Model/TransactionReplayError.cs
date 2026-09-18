// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Safe terminal replay failure details, or &#x60;null&#x60; when no execution failure was recorded.</summary>

public sealed class TransactionReplayError
{
    /// <summary>Stable replay failure code, or &#x60;null&#x60; when no specific code was captured.</summary>
    [JsonPropertyName("code")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> Code { get; set; }

    /// <summary>Safe operator-facing replay failure explanation, or &#x60;null&#x60; when unavailable.</summary>
    [JsonPropertyName("message")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> Message { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
