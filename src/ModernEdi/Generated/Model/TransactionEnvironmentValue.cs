// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Isolated transaction and queue environment used for this response object.</summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum TransactionEnvironmentValue
{

    [EnumMember(Value = "production")]
    Production,

    [EnumMember(Value = "test")]
    Test

}
