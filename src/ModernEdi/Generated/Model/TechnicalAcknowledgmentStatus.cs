// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Stable requested-TA1 lifecycle and normalized TA104 outcome.</summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum TechnicalAcknowledgmentStatus
{

    [EnumMember(Value = "not_requested")]
    NotRequested,

    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "received")]
    Received,

    [EnumMember(Value = "received_with_errors")]
    ReceivedWithErrors,

    [EnumMember(Value = "rejected")]
    Rejected,

    [EnumMember(Value = "unknown")]
    Unknown,

    [EnumMember(Value = "overdue")]
    Overdue

}
