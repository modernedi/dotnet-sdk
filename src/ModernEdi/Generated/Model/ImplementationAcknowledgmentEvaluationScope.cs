// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Outcome level selected for one transaction from a correlated 999. Group and acknowledgment fallbacks use the documented primary-aware conservative reduction with nested IK5 statuses; raw AK9 and IK5 objects are unchanged. </summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum ImplementationAcknowledgmentEvaluationScope
{

    [EnumMember(Value = "transaction_set")]
    TransactionSet,

    [EnumMember(Value = "implementation_group")]
    ImplementationGroup,

    [EnumMember(Value = "implementation_acknowledgment")]
    ImplementationAcknowledgment

}
