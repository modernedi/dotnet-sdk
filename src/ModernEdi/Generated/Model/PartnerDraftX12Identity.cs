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

public sealed class PartnerDraftX12Identity
{
    /// <summary>Draft ISA qualifier. Attaching an AS2 connection requires exactly 2 characters.</summary>
    [JsonPropertyName("isaQualifier")]
    [JsonRequired]
    public string IsaQualifier { get; set; } = default!;

    /// <summary>Draft ISA id. Attaching an AS2 connection requires between 1 and 15 characters inclusive.</summary>
    [JsonPropertyName("isaId")]
    [JsonRequired]
    public string IsaId { get; set; } = default!;

    /// <summary>Draft GS id. Attaching an AS2 connection requires between 1 and 15 characters inclusive.</summary>
    [JsonPropertyName("gsId")]
    [JsonRequired]
    public string GsId { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
