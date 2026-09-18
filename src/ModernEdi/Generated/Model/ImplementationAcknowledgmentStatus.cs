// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Stable normalized 999 acknowledgment status used for aggregate, group, and transaction-set results. Raw IK501 &#x60;A&#x60; is not clean when its AK2 loop contains IK3/IK4 error detail; that contradictory result is &#x60;unknown&#x60;. </summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum ImplementationAcknowledgmentStatus
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
