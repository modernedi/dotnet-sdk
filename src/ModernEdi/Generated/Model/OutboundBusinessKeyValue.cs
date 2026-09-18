// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Scalar business-key value. Numbers and booleans in the JSON envelope are accepted and stored as strings.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class OutboundBusinessKeyValue : JsonValue
{
    public OutboundBusinessKeyValue(JsonElement value) : base(value) { }
    public OutboundBusinessKeyValue(object value) : base(value) { }
}
