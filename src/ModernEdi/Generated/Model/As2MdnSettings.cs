// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Optional MDN interoperability controls. Omitted values default to unencrypted MDNs and synchronous error dispositions.</summary>

public sealed class As2MdnSettings
{
    /// <summary>When true, ModernEDI attempts to encrypt MDNs returned for inbound messages with the partner certificate and configured outbound encryption algorithm. If MDN encryption itself fails, ModernEDI returns an unencrypted error MDN so the partner still receives a disposition.</summary>
    [JsonPropertyName("encrypt")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> Encrypt { get; set; }

    /// <summary>When true, an inbound processing failure or error is returned as a synchronous MDN even when the normal receipt flow is asynchronous.</summary>
    [JsonPropertyName("forceSynchronousForErrors")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> ForceSynchronousForErrors { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
