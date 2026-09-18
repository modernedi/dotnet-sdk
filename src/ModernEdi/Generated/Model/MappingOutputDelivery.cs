// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Safe delivery category without infrastructure identifiers:  - &#x60;MAPPED_OUTPUTS&#x60;: managed polling and per-partner webhook delivery - &#x60;TRANSACTION_RECORD&#x60;: incoming result retained on the transaction record - &#x60;OUTBOUND_AS2&#x60;: outbound source-to-X12 transform used by AS2 send APIs </summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum MappingOutputDelivery
{

    [EnumMember(Value = "MAPPED_OUTPUTS")]
    MAPPEDOUTPUTS,

    [EnumMember(Value = "TRANSACTION_RECORD")]
    TRANSACTIONRECORD,

    [EnumMember(Value = "OUTBOUND_AS2")]
    OUTBOUNDAS2

}
