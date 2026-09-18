// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>&#x60;PENDING&#x60; means the aggregate database change committed and runtime publication is retrying. &#x60;SUCCEEDED&#x60; means the stored apply operation is terminal. </summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum ConfigurationApplyOperationStatus
{

    [EnumMember(Value = "PENDING")]
    PENDING,

    [EnumMember(Value = "SUCCEEDED")]
    SUCCEEDED

}
