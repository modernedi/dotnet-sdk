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

public sealed class IntegrationChangeTransactionReference
{
    /// <summary>AS2 Message-Id of the transaction whose public state changed.</summary>
    [JsonPropertyName("messageId")]
    [JsonRequired]
    public string MessageId { get; set; } = default!;

    /// <summary>Transaction-local &#x60;GS06#ST02&#x60; key identifying the changed row.</summary>
    [JsonPropertyName("transactionKey")]
    [JsonRequired]
    public string TransactionKey { get; set; } = default!;

    /// <summary>Source inbound message for an outbound reply, or &#x60;null&#x60;.</summary>
    [JsonPropertyName("replyToMessageId")]
    [JsonRequired]
    public string? ReplyToMessageId { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
