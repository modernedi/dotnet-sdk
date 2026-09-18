// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>ModernEDI endpoint and X12 sender identity for one workspace environment.</summary>

public sealed class As2EnvironmentProfile
{
    /// <summary></summary>
    [JsonPropertyName("x12Sender")]
    [JsonRequired]
    public As2EnvironmentProfileX12Sender X12Sender { get; set; } = default!;

    /// <summary>HTTPS AS2 receive URL to configure at the partner, or &#x60;null&#x60; while the endpoint is unavailable.</summary>
    [JsonPropertyName("as2Url")]
    [JsonRequired]
    public string? As2Url { get; set; } = default!;

    /// <summary>Plain-HTTP endpoint when included in the tenant&#39;s plan and provisioned.</summary>
    [JsonPropertyName("httpAs2Url")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> HttpAs2Url { get; set; }

    /// <summary>ModernEDI AS2 identifier sent as &#x60;AS2-From&#x60; and expected as inbound &#x60;AS2-To&#x60;, or &#x60;null&#x60; while unprovisioned.</summary>
    [JsonPropertyName("as2Identifier")]
    [JsonRequired]
    public string? As2Identifier { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
