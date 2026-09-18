// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One derived operator-timeline entry. &#x60;type&#x60; is a discriminator for the stable &#x60;details&#x60; payload; clients do not need to infer fields from &#x60;label&#x60; or reverse-engineer examples. </summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class TransactionEvent : JsonValue
{
    public TransactionEvent(JsonElement value) : base(value) { }
    public TransactionEvent(object value) : base(value) { }
}
