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

public sealed class MappingRuntimeFailuresResponse
{
    /// <summary>Always &#x60;true&#x60;; invalid filters, cursors, or runtime-read failures use an error response.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary>Reverse-chronological safe diagnostics matching the supplied environment and filters.</summary>
    [JsonPropertyName("failures")]
    [JsonRequired]
    public List<TransactionMappingAttempt> Failures { get; set; } = default!;

    /// <summary>True when &#x60;nextCursor&#x60; should be sent back for another page.</summary>
    [JsonPropertyName("hasMore")]
    [JsonRequired]
    public bool HasMore { get; set; } = default!;

    /// <summary>Opaque cursor for the next page, or &#x60;null&#x60; when this page is complete.</summary>
    [JsonPropertyName("nextCursor")]
    [JsonRequired]
    public string? NextCursor { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
