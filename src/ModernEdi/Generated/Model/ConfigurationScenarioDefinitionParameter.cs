// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>A typed value supplied when a run starts through the Workspace UI or API, or resolved from its declared default when optional.</summary>

public sealed class ConfigurationScenarioDefinitionParameter
{
    /// <summary>A stable identifier beginning with a letter and containing at most 128 letters, digits, underscores, or hyphens.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("type")]
    [JsonRequired]
    public string Type { get; set; } = default!;

    /// <summary>Whether the run must explicitly provide this value. A required parameter cannot also have a default.</summary>
    [JsonPropertyName("required")]
    [JsonRequired]
    public bool Required { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("elementType")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> ElementType { get; set; }

    /// <summary>Optional JSON value used when the run omits a non-required parameter.</summary>
    [JsonPropertyName("default")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<Object?> Default { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
