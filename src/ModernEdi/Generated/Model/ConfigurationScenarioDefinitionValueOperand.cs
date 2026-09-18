// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Closed discriminated union used by assertions, branch predicates, and effective-time expressions.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationScenarioDefinitionValueOperand : JsonValue
{
    public ConfigurationScenarioDefinitionValueOperand(JsonElement value) : base(value) { }
    public ConfigurationScenarioDefinitionValueOperand(object value) : base(value) { }
}
