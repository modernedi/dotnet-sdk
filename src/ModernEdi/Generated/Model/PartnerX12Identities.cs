// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Production is always configured. Test is &#x60;null&#x60; for a production-only partner.</summary>

public sealed class PartnerX12Identities
{
    /// <summary></summary>
    [JsonPropertyName("production")]
    [JsonRequired]
    public PartnerX12Identity Production { get; set; } = default!;

    /// <summary>Complete test X12 sender identity, or &#x60;null&#x60; when this partner has no separate test identity.</summary>
    [JsonPropertyName("test")]
    [JsonRequired]
    public PartnerX12Identity? Test { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
