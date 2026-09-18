// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One complete retained transaction artifact returned only by the individual document endpoint. Its &#x60;content&#x60; body is required. </summary>

[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class TransactionDocument : JsonValue
{
    public TransactionDocument(JsonElement value) : base(value) { }
    public TransactionDocument(object value) : base(value) { }
}
