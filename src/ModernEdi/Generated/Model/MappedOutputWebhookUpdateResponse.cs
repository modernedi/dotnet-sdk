// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Successful mapped-output webhook configuration update.</summary>

public sealed class MappedOutputWebhookUpdateResponse
{
    /// <summary>Always &#x60;true&#x60;; endpoint validation or configuration conflicts use an error response.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("webhook")]
    [JsonRequired]
    public MappedOutputWebhookStatus Webhook { get; set; } = default!;

    /// <summary>Present only when a signing secret was created or rotated. It is never returned again.</summary>
    [JsonPropertyName("plainTextSigningSecret")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> PlainTextSigningSecret { get; set; }

    /// <summary>Present with &#x60;plainTextSigningSecret&#x60; to remind the caller to save it.</summary>
    [JsonPropertyName("message")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> Message { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
