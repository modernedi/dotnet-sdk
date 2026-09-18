// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Closed set of normalized AS2 receipt-assurance statuses accepted by exact transaction-list filtering. Response models use a separate forward-compatible enum so a newer response status does not prevent an older SDK from reading the row. </summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum FilterableTransactionMdnStatus
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
