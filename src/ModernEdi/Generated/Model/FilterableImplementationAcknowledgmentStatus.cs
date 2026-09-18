// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Closed set of normalized 999 statuses accepted by exact transaction-list filtering. Response models use a separate forward-compatible enum so a newer response status does not prevent an older SDK from reading the row. </summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum FilterableImplementationAcknowledgmentStatus
{

    [EnumMember(Value = "accepted")]
    Accepted,

    [EnumMember(Value = "accepted_with_errors")]
    AcceptedWithErrors,

    [EnumMember(Value = "partially_accepted")]
    PartiallyAccepted,

    [EnumMember(Value = "rejected")]
    Rejected,

    [EnumMember(Value = "unknown")]
    Unknown

}
