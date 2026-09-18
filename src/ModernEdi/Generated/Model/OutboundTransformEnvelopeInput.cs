// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Source document to transform. For XML or text content types this must be a string. For JSON content types this may be a JSON object, array, string, number, boolean, or null. </summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class OutboundTransformEnvelopeInput : JsonValue
{
    public OutboundTransformEnvelopeInput(JsonElement value) : base(value) { }
    public OutboundTransformEnvelopeInput(object value) : base(value) { }
}
