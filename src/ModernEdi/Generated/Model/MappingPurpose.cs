// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Purpose of the runtime map that produced this output. &#x60;PROCESSING&#x60; means the output is for the normal application workflow. &#x60;ACKNOWLEDGMENT&#x60; means the output is an automatically generated response document. </summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum MappingPurpose
{

    [EnumMember(Value = "PROCESSING")]
    PROCESSING,

    [EnumMember(Value = "ACKNOWLEDGMENT")]
    ACKNOWLEDGMENT

}
