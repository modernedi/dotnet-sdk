// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Parsed JSON object for JSON files or exact mapping source for text files.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationExportFileContent : JsonValue
{
    public ConfigurationExportFileContent(JsonElement value) : base(value) { }
    public ConfigurationExportFileContent(object value) : base(value) { }
}
