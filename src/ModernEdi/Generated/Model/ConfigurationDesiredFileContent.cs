// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Parsed manifest or resource object, or exact mapping-source text.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationDesiredFileContent : JsonValue
{
    public ConfigurationDesiredFileContent(JsonElement value) : base(value) { }
    public ConfigurationDesiredFileContent(object value) : base(value) { }
}
