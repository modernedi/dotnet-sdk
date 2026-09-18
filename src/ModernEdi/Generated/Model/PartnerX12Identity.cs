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

public sealed class PartnerX12Identity
{
    /// <summary>ISA qualifier ModernEDI expects for this partner in the selected environment. Connected partners always use exactly 2 characters; detached draft values may be incomplete.</summary>
    [JsonPropertyName("isaQualifier")]
    [JsonRequired]
    public string IsaQualifier { get; set; } = default!;

    /// <summary>ISA id ModernEDI expects for this partner in the selected environment. Connected partners always use between 1 and 15 characters inclusive; detached draft values may be incomplete.</summary>
    [JsonPropertyName("isaId")]
    [JsonRequired]
    public string IsaId { get; set; } = default!;

    /// <summary>GS sender or receiver id configured for this partner in the selected environment. Connected partners always use between 1 and 15 characters inclusive; detached draft values may be incomplete.</summary>
    [JsonPropertyName("gsId")]
    [JsonRequired]
    public string GsId { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
