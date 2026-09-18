// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Source trading partner whose outgoing map and configuration were selected.</summary>

public sealed class OutboundPreviewResponsePartner
{
    /// <summary>Stable workspace-scoped partner id used for exact selection.</summary>
    [JsonPropertyName("partnerId")]
    [JsonRequired]
    public int PartnerId { get; set; } = default!;

    /// <summary>Current customer-visible name of the selected partner.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
