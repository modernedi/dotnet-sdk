// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One raw parameter value. The selected definition is authoritative for its declared type. Send decimal values as JSON strings when exact decimal precision matters.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ScenarioRunParameterScalar : JsonValue
{
    public ScenarioRunParameterScalar(JsonElement value) : base(value) { }
    public ScenarioRunParameterScalar(object value) : base(value) { }
}
