// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>The objective rule that tells a run no more documents are expected for one repeated step. fixed closes at the required fixed count; max_reached closes only at the authored maximum; expected_count closes at a required or defaulted run parameter, including an explicit zero. Branch selection supplies the no-document outcome for an unselected destination. There is no manual-close operation in v1.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationScenarioDefinitionOccurrenceClosure : JsonValue
{
    public ConfigurationScenarioDefinitionOccurrenceClosure(JsonElement value) : base(value) { }
    public ConfigurationScenarioDefinitionOccurrenceClosure(object value) : base(value) { }
}
