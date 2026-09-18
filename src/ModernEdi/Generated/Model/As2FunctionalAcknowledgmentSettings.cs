// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Optional automatic X12 acknowledgment MIME packaging for 997s and partner-enabled 999s. Omit the object or &#x60;messageStructure&#x60; to use &#x60;SIGNED_ENCRYPTED&#x60;.</summary>

public sealed class As2FunctionalAcknowledgmentSettings
{
    /// <summary>MIME signing, encryption, and compression structure used when ModernEDI automatically sends an X12 acknowledgment (997 or partner-enabled 999) to this partner.</summary>
    [JsonPropertyName("messageStructure")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> MessageStructure { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
