// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Current production and optional test X12 identities. Detached drafts may contain incomplete authoring values.</summary>

[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationPartnerSpecX12 : JsonValue
{
    public ConfigurationPartnerSpecX12(JsonElement value) : base(value) { }
    public ConfigurationPartnerSpecX12(object value) : base(value) { }
}
