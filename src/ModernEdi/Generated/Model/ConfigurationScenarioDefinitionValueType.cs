// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Closed evaluator value type. list and set contain scalar values only and require elementType.</summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum ConfigurationScenarioDefinitionValueType
{

    [EnumMember(Value = "string")]
    String,

    [EnumMember(Value = "decimal")]
    Decimal,

    [EnumMember(Value = "date")]
    Date,

    [EnumMember(Value = "time")]
    Time,

    [EnumMember(Value = "timestamp")]
    Timestamp,

    [EnumMember(Value = "boolean")]
    Boolean,

    [EnumMember(Value = "list")]
    List,

    [EnumMember(Value = "set")]
    Set

}
