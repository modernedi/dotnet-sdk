// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>AS2 MDN report. Inspect &#x60;id&#x60; to distinguish the original transaction&#39;s full MDN metadata from compact MDN metadata attached to a 997 or 999. </summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class TransactionMdnDocument : JsonValue
{
    public TransactionMdnDocument(JsonElement value) : base(value) { }
    public TransactionMdnDocument(object value) : base(value) { }
}
