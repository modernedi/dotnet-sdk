// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>When a replacement or cancellation begins to govern the conversation. observed_at uses the time ModernEDI observed the later document. value uses an explicit timestamp, such as effectiveTimestamp extracted from an X12 860 order change. The value must be a timestamp, not only a date or clock time. A fact value belongs to the matched revision pair and must come from its source or later document; for a previous-matched same-step revision, it is read from the later revision occurrence.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationScenarioDefinitionEffectiveAt : JsonValue
{
    public ConfigurationScenarioDefinitionEffectiveAt(JsonElement value) : base(value) { }
    public ConfigurationScenarioDefinitionEffectiveAt(object value) : base(value) { }
}
