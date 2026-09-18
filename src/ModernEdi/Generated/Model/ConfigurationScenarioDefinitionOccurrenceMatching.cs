// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>How actual repeated documents are paired across a transition, plus what happens to documents with no match. correlate pairs documents whose declared fact or reply-link conditions pass; position pairs by observation order; previous pairs each revision with the immediately preceding occurrence of the same step, such as the second 860 order change with the first.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationScenarioDefinitionOccurrenceMatching : JsonValue
{
    public ConfigurationScenarioDefinitionOccurrenceMatching(JsonElement value) : base(value) { }
    public ConfigurationScenarioDefinitionOccurrenceMatching(object value) : base(value) { }
}
