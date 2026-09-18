// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>OneOf discriminator: workspace accepts only kind; partner also requires a positive tenant partner ID.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationScenarioBindingEndpoint : JsonValue
{
    public ConfigurationScenarioBindingEndpoint(JsonElement value) : base(value) { }
    public ConfigurationScenarioBindingEndpoint(object value) : base(value) { }
}
