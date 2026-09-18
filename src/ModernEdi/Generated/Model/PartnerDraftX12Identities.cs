// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Resolved authoring values returned for a detached partner draft. Production fields may remain incomplete until an AS2 connection is attached. Test is &#x60;null&#x60; when no test identity has been entered.</summary>

public sealed class PartnerDraftX12Identities
{
    /// <summary></summary>
    [JsonPropertyName("production")]
    [JsonRequired]
    public PartnerDraftX12Identity Production { get; set; } = default!;

    /// <summary>Current test authoring values, or &#x60;null&#x60; when no test identity has been entered.</summary>
    [JsonPropertyName("test")]
    [JsonRequired]
    public PartnerDraftX12Identity? Test { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
