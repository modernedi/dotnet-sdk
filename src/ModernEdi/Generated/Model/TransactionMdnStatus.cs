// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Normalized AS2 receipt-assurance status. Only &#x60;processed&#x60; is a clean completed receipt; &#x60;pending&#x60; is still within the response window and every other state requires operator review. </summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum TransactionMdnStatus
{

    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "processed")]
    Processed,

    [EnumMember(Value = "warning")]
    Warning,

    [EnumMember(Value = "rejected")]
    Rejected,

    [EnumMember(Value = "invalid")]
    Invalid,

    [EnumMember(Value = "mic_mismatch")]
    MicMismatch,

    [EnumMember(Value = "overdue")]
    Overdue

}
