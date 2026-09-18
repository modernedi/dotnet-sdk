// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Select one declared per-occurrence fact value, aggregate values across occurrences as a list or set, or select the first/latest observed occurrence. Correlations require value.</summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum ConfigurationScenarioDefinitionFactProjection
{

    [EnumMember(Value = "value")]
    Value,

    [EnumMember(Value = "list")]
    List,

    [EnumMember(Value = "set")]
    Set,

    [EnumMember(Value = "first")]
    First,

    [EnumMember(Value = "latest")]
    Latest

}
