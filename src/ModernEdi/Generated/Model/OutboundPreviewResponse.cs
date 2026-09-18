// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Dry-run result showing map selection, generated X12, validation diagnostics, and partner context without sending AS2.</summary>

public sealed class OutboundPreviewResponse
{
    /// <summary>Always &#x60;true&#x60;; map-selection or transform failures use the documented error response instead.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary>Complete generated X12 that would be sent by &#x60;/v1/as2/send&#x60;.</summary>
    [JsonPropertyName("generatedX12")]
    [JsonRequired]
    public string GeneratedX12 { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("validation")]
    [JsonRequired]
    public X12ValidationResult Validation { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("mapping")]
    [JsonRequired]
    public OutboundPreviewResponseMapping Mapping { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("partner")]
    [JsonRequired]
    public OutboundPreviewResponsePartner Partner { get; set; } = default!;

    /// <summary>Business identifier that would be recorded with a real send, or &#x60;null&#x60; when none was supplied.</summary>
    [JsonPropertyName("businessKey")]
    [JsonRequired]
    public OutboundBusinessKey? BusinessKey { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
