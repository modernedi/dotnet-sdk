// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Stable normalized acknowledgment status used for group and transaction-set results. This is not a direct alias for AK901 or AK501; in particular, an AK501 &#x60;A&#x60; with AK3/AK4 or AK502 and later error detail is &#x60;accepted_with_errors&#x60;, while the raw &#x60;acknowledgmentCode&#x60; remains &#x60;A&#x60;. </summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum FunctionalAcknowledgmentStatus
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
