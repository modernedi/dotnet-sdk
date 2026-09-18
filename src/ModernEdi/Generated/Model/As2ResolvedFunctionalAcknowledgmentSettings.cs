// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Fully resolved MIME packaging for automatic X12 acknowledgments (997 or partner-enabled 999).</summary>

public sealed class As2ResolvedFunctionalAcknowledgmentSettings
{
    /// <summary>MIME signing, encryption, and compression structure used when ModernEDI automatically sends an X12 acknowledgment (997 or partner-enabled 999) to this partner.</summary>
    [JsonPropertyName("messageStructure")]
    [JsonRequired]
    public string MessageStructure { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
