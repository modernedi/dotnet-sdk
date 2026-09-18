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

public sealed class MappedOutputWebhookUpdateRequest
{
    /// <summary>Enables or disables push delivery for this partner. Disabling retains the stored endpoint and signing secret for later use; re-enabling still requires &#x60;endpointUrl&#x60; in this request.</summary>
    [JsonPropertyName("enabled")]
    [JsonRequired]
    public bool Enabled { get; set; } = default!;

    /// <summary>Required when &#x60;enabled&#x60; is true. Must be an absolute HTTPS URL without user information or a fragment and use a publicly routable host. DNS is revalidated before every delivery.</summary>
    [JsonPropertyName("endpointUrl")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> EndpointUrl { get; set; }

    /// <summary>When true on an enabled webhook, replaces the signing secret and returns the new plaintext value once. Enabling a webhook without an existing secret creates one even when this is false.</summary>
    [JsonPropertyName("rotateSigningSecret")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> RotateSigningSecret { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
