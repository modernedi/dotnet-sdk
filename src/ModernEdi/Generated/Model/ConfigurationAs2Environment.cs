// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>An environment has either one inline public certificate or a file reference, never both. File references are confined to this connection. Production and Test may share one file; replacing it changes both environments&#39; certificates.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationAs2Environment : JsonValue
{
    public ConfigurationAs2Environment(JsonElement value) : base(value) { }
    public ConfigurationAs2Environment(object value) : base(value) { }
}
