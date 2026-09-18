// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Metadata for one retained transaction artifact. &#x60;type&#x60; selects the renderer and concrete &#x60;metadata&#x60; schema. The MDN shapes are further distinguished by stable &#x60;id&#x60;: &#x60;mdn-report&#x60; contains receipt-assurance metadata, while &#x60;functional-ack-mdn-report&#x60; and &#x60;implementation-ack-mdn-report&#x60; contain the Message-Id and disposition of the 997&#39;s or 999&#39;s own MDN. Document indexes never include &#x60;content&#x60;. </summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class TransactionDocumentMetadata : JsonValue
{
    public TransactionDocumentMetadata(JsonElement value) : base(value) { }
    public TransactionDocumentMetadata(object value) : base(value) { }
}
