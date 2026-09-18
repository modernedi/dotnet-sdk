// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Closed scalar type used directly or as the element type of list and set values.</summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum ConfigurationScenarioDefinitionScalarType
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
    Boolean

}
