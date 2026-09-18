// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>The business document carried by a step. The server verifies the transaction-set code against ModernEDI&#39;s X12 catalog.</summary>

public sealed class ConfigurationScenarioDefinitionTransaction
{
    /// <summary>Transaction standard. v1 supports X12.</summary>
    [JsonPropertyName("standard")]
    [JsonRequired]
    public string Standard { get; set; } = default!;

    /// <summary>Known three-digit X12 business transaction set, such as 850, 855, 856, 810, 875, 880, 940, 945, 204, 214, 300, 301, or 315. Use assurance for 997/999 acknowledgments.</summary>
    [JsonPropertyName("transactionSet")]
    [JsonRequired]
    public string TransactionSet { get; set; } = default!;

    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("businessUsage")]
    [JsonRequired]
    public string BusinessUsage { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
