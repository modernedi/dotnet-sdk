// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>For a same-step supersedes transition whose step occurrence max is at least 2, pair occurrence n with n-1. The first occurrence is recorded as the initial revision, so both matching.unmatched and effect.unmatched must be record. A separate cross-step transition can link an initial 850 to the first 860. cancels uses a distinct cancellation-document step and cannot use previous matching.</summary>

public sealed class PreviousOccurrenceMatching
{
    /// <summary></summary>
    [JsonPropertyName("strategy")]
    [JsonRequired]
    public string Strategy { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("quantifiers")]
    [JsonRequired]
    public List<PreviousOccurrenceMatchingQuantifiersInner> Quantifiers { get; set; } = default!;

    /// <summary>Record the first occurrence because it has no predecessor; later occurrences must match their immediate predecessor.</summary>
    [JsonPropertyName("unmatched")]
    [JsonRequired]
    public string Unmatched { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
