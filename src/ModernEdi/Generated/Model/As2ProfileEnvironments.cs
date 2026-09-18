// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Environment-specific inbound endpoints and ModernEDI sender identities.</summary>

public sealed class As2ProfileEnvironments
{
    /// <summary></summary>
    [JsonPropertyName("production")]
    [JsonRequired]
    public As2EnvironmentProfile Production { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("test")]
    [JsonRequired]
    public As2EnvironmentProfile Test { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
