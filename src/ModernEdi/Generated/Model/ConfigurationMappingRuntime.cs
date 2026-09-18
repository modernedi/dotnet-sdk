// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Exact advanced runtime values preserved by workspace authoring and deterministic export. Incoming mappings contain &#x60;activeAttributes&#x60;; outgoing mappings contain &#x60;extraFields&#x60;. Most integrations should use the stable &#x60;deliveredMetadata&#x60; and &#x60;output.delivery&#x60; fields instead. These maps exist so source-control exports do not discard established runtime behavior that is outside the closed customer-facing selectors. </summary>

public sealed class ConfigurationMappingRuntime
{
    /// <summary>Complete incoming runtime attribute selection, keyed by the established mapping-runtime attribute name.</summary>
    [JsonPropertyName("activeAttributes")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<Dictionary<string, bool>> ActiveAttributes { get; set; }

    /// <summary>Complete outgoing runtime metadata preserved with the transform.</summary>
    [JsonPropertyName("extraFields")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<Dictionary<string, string>> ExtraFields { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
