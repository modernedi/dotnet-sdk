// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>OneOf discriminator selecting an evidence-constrained runtime mapping, a registered active executor adapter, or observation-only evidence.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationScenarioBindingTarget : JsonValue
{
    public ConfigurationScenarioBindingTarget(JsonElement value) : base(value) { }
    public ConfigurationScenarioBindingTarget(object value) : base(value) { }
}
