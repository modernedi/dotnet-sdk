// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>ModernEDI X12 envelope identity for documents sent from this environment.</summary>

public sealed class As2EnvironmentProfileX12Sender
{
    /// <summary>ISA05/ISA07 qualifier for ModernEDI&#39;s environment identity, or &#x60;null&#x60; while unprovisioned.</summary>
    [JsonPropertyName("isaQualifier")]
    [JsonRequired]
    public string? IsaQualifier { get; set; } = default!;

    /// <summary>ISA06/ISA08 identifier for ModernEDI&#39;s environment identity, or &#x60;null&#x60; while unprovisioned.</summary>
    [JsonPropertyName("isaId")]
    [JsonRequired]
    public string? IsaId { get; set; } = default!;

    /// <summary>GS02/GS03 identifier for ModernEDI&#39;s environment identity, or &#x60;null&#x60; while unprovisioned.</summary>
    [JsonPropertyName("gsId")]
    [JsonRequired]
    public string? GsId { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
