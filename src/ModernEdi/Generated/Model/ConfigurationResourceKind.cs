// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Exportable ModernEDI configuration resource type.</summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum ConfigurationResourceKind
{

    [EnumMember(Value = "As2Connection")]
    As2Connection,

    [EnumMember(Value = "Partner")]
    Partner,

    [EnumMember(Value = "Mapping")]
    Mapping,

    [EnumMember(Value = "ScenarioDefinition")]
    ScenarioDefinition,

    [EnumMember(Value = "ScenarioBinding")]
    ScenarioBinding

}
