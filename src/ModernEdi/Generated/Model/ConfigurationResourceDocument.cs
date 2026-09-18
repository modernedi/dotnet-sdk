// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Portable connection, partner, mapping, or optional scenario desired-state document. References use stable UUID keys rather than workspace database ids. Scenario resources contain the complete authored document under spec.source; runtime snapshots and evidence are not source configuration.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationResourceDocument : JsonValue
{
    public ConfigurationResourceDocument(JsonElement value) : base(value) { }
    public ConfigurationResourceDocument(object value) : base(value) { }
}
