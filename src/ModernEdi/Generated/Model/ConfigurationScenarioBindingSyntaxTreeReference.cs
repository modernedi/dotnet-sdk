// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Optional authoring-time pin to an exact X12 release and transaction set. Both fields are required when this object is present.</summary>

public sealed class ConfigurationScenarioBindingSyntaxTreeReference
{
    /// <summary>X12 release token. Apply canonicalizes accepted forms to a six-digit release such as 004010.</summary>
    [JsonPropertyName("x12Version")]
    [JsonRequired]
    public string X12Version { get; set; } = default!;

    /// <summary>Known three-digit X12 transaction set. The code must match the referenced definition step.</summary>
    [JsonPropertyName("transactionSet")]
    [JsonRequired]
    public string TransactionSet { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
