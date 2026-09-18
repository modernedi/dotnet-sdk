// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>An explicit requirement over source occurrences, target occurrences, matched pairs, or matches per endpoint occurrence.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationScenarioDefinitionMatchQuantifier : JsonValue
{
    public ConfigurationScenarioDefinitionMatchQuantifier(JsonElement value) : base(value) { }
    public ConfigurationScenarioDefinitionMatchQuantifier(object value) : base(value) { }
}
