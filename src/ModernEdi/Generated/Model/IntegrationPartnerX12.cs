// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Connected partners satisfy &#x60;PartnerX12Identities&#x60;; detached drafts may contain incomplete authoring values until an AS2 connection is attached.</summary>

[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class IntegrationPartnerX12 : JsonValue
{
    public IntegrationPartnerX12(JsonElement value) : base(value) { }
    public IntegrationPartnerX12(object value) : base(value) { }
}
