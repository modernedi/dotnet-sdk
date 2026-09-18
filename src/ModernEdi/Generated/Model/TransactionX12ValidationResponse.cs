// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Structured validation of the X12 content retained for one visible transaction.</summary>

public sealed class TransactionX12ValidationResponse
{
    /// <summary>Always &#x60;true&#x60;; invalid retained X12 is represented by &#x60;validation.valid&#x3D;false&#x60;.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary>Message id from the requested transaction reference.</summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string MessageId { get; set; } = default!;

    /// <summary>Transaction key from the requested transaction reference.</summary>
    [JsonPropertyName("transactionKey")]
    [JsonRequired]
    public string TransactionKey { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("validation")]
    [JsonRequired]
    public X12ValidationResult Validation { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
