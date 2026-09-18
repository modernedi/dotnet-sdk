// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Per-partner HTTPS push configuration and last observed delivery attempt.</summary>

public sealed class MappedOutputWebhookStatus
{
    /// <summary>Stable workspace-scoped partner id whose mapped outputs use this webhook.</summary>
    [JsonPropertyName("partnerId")]
    [JsonRequired]
    public int PartnerId { get; set; } = default!;

    /// <summary>Whether ModernEDI currently attempts HTTPS push delivery for this partner.</summary>
    [JsonPropertyName("enabled")]
    [JsonRequired]
    public bool Enabled { get; set; } = default!;

    /// <summary>Whether ModernEDI has a secret for signing webhook requests; the full secret is never returned here.</summary>
    [JsonPropertyName("signingSecretConfigured")]
    [JsonRequired]
    public bool SigningSecretConfigured { get; set; } = default!;

    /// <summary>Quoted SHA-256 configuration ETag, also returned in the HTTP &#x60;ETag&#x60; header.</summary>
    [JsonPropertyName("etag")]
    [JsonRequired]
    public string Etag { get; set; } = default!;

    /// <summary>Configured public HTTPS destination, or &#x60;null&#x60; when no endpoint has been stored.</summary>
    [JsonPropertyName("endpointUrl")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> EndpointUrl { get; set; }

    /// <summary>Last four characters only; the signing secret is never returned.</summary>
    [JsonPropertyName("signingSecretLastFour")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> SigningSecretLastFour { get; set; }

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("activatedAt")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> ActivatedAt { get; set; }

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("lastDeliveryAttemptAt")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> LastDeliveryAttemptAt { get; set; }

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("lastDeliverySuccessAt")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> LastDeliverySuccessAt { get; set; }

    /// <summary>Most recent webhook HTTP response status, or &#x60;null&#x60; before a response has been recorded.</summary>
    [JsonPropertyName("lastDeliveryStatusCode")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int?> LastDeliveryStatusCode { get; set; }

    /// <summary>Safe most-recent delivery error, or &#x60;null&#x60; when the latest attempt succeeded or none has occurred.</summary>
    [JsonPropertyName("lastDeliveryError")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> LastDeliveryError { get; set; }

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("createdAt")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> CreatedAt { get; set; }

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("lastUpdatedAt")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> LastUpdatedAt { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
