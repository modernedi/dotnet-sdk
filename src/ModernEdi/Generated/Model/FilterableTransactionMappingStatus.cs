// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Durable consolidated mapping states available to exact list filtering. &#x60;UNAVAILABLE&#x60; is intentionally excluded because it describes a request-local telemetry read failure rather than an indexed transaction state. </summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum FilterableTransactionMappingStatus
{

    [EnumMember(Value = "NOT_RECORDED")]
    NOTRECORDED,

    [EnumMember(Value = "SUCCEEDED")]
    SUCCEEDED,

    [EnumMember(Value = "FAILED")]
    FAILED,

    [EnumMember(Value = "COMPLETED_WITH_ERRORS")]
    COMPLETEDWITHERRORS,

    [EnumMember(Value = "RECOVERED")]
    RECOVERED

}
