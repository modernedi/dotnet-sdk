// Generated from the ModernEDI Integration API 1.36.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary></summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationVerificationRunCasesInner : JsonValue
{
    public ConfigurationVerificationRunCasesInner(JsonElement value) : base(value) { }
    public ConfigurationVerificationRunCasesInner(object value) : base(value) { }
}
