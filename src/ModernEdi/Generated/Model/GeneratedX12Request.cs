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

public sealed class GeneratedX12Request
{
    /// <summary>Complete X12 interchange to validate and send without mapping.</summary>
    [JsonPropertyName("x12")]
    [JsonRequired]
    public string X12 { get; set; } = default!;

    /// <summary>Optional business identifier stored for transaction search and reconciliation.</summary>
    [JsonPropertyName("businessKey")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<OutboundBusinessKey> BusinessKey { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
