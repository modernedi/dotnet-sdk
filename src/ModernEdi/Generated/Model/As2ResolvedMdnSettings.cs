// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Fully resolved Message Disposition Notification compatibility settings.</summary>

public sealed class As2ResolvedMdnSettings
{
    /// <summary>When true, ModernEDI attempts to encrypt MDNs returned for inbound messages with the partner certificate and configured outbound encryption algorithm. If MDN encryption itself fails, ModernEDI returns an unencrypted error MDN so the partner still receives a disposition.</summary>
    [JsonPropertyName("encrypt")]
    [JsonRequired]
    public bool Encrypt { get; set; } = default!;

    /// <summary>When true, an inbound processing failure or error is returned as a synchronous MDN even when the normal receipt flow is asynchronous.</summary>
    [JsonPropertyName("forceSynchronousForErrors")]
    [JsonRequired]
    public bool ForceSynchronousForErrors { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
