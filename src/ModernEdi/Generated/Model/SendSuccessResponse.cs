// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Confirmation that ModernEDI validated, packaged, and handed an outbound AS2 message to the configured partner endpoint.</summary>

public sealed class SendSuccessResponse
{
    /// <summary>Always &#x60;true&#x60;; transport or validation failures use the documented error response instead.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary>AS2 Message-Id assigned to the outbound message.</summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string MessageId { get; set; } = default!;

    /// <summary>Final X12 sent downstream after ModernEDI syntax-checks it and wraps it for AS2 delivery. For mapped endpoints this is generated output; for &#x60;/v1/as2/x12/...&#x60; endpoints it is the validated X12 supplied by the caller. </summary>
    [JsonPropertyName("x12")]
    [JsonRequired]
    public string X12 { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
