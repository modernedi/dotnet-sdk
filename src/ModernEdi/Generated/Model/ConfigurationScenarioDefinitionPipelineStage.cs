// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One named action in the ordered processing of an observed document. A definition says prepare, map, exchange, extract facts, check evidence, or emit a checkpoint; the binding later selects the concrete map, partner, or adapter. Keeping those artifact IDs out of the definition lets the same conversation recipe be reused by another tenant.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationScenarioDefinitionPipelineStage : JsonValue
{
    public ConfigurationScenarioDefinitionPipelineStage(JsonElement value) : base(value) { }
    public ConfigurationScenarioDefinitionPipelineStage(object value) : base(value) { }
}
