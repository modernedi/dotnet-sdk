// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One portable desired file or the optional exported advisory snapshot. The role makes these alternatives unambiguous.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationPlanFile : JsonValue
{
    public ConfigurationPlanFile(JsonElement value) : base(value) { }
    public ConfigurationPlanFile(object value) : base(value) { }
}
