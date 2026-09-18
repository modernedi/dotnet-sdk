// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Desired change to one stable portable resource identity.</summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum ConfigurationPlanAction
{

    [EnumMember(Value = "CREATE")]
    CREATE,

    [EnumMember(Value = "UPDATE")]
    UPDATE,

    [EnumMember(Value = "DELETE")]
    DELETE

}
