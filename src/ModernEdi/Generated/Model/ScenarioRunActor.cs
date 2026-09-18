// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>The member or Integration API key that requested the operation. No credential is included.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ScenarioRunActor : JsonValue
{
    public ScenarioRunActor(JsonElement value) : base(value) { }
    public ScenarioRunActor(object value) : base(value) { }
}
