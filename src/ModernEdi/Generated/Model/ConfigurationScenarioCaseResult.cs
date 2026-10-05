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

public sealed class ConfigurationScenarioCaseResult
{
    /// <summary>Binding owning this saved conversation test.</summary>
    [JsonPropertyName("scenarioBindingResourceKey")]
    [JsonRequired]
    public string ScenarioBindingResourceKey { get; set; } = default!;

    /// <summary>Portable case ID.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary>Portable case display name.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    /// <summary>No live run, EDI send, transport receipt, or partner acknowledgement is created.</summary>
    [JsonPropertyName("mode")]
    [JsonRequired]
    public string Mode { get; set; } = default!;

    /// <summary>Lowercase hexadecimal SHA-256 digest.</summary>
    [JsonPropertyName("caseSha256")]
    [JsonRequired]
    public string CaseSha256 { get; set; } = default!;

    /// <summary>Expected interpreter outcome. A negative test can pass by reproducing its named failing checks.</summary>
    [JsonPropertyName("expectedOutcome")]
    [JsonRequired]
    public string ExpectedOutcome { get; set; } = default!;

    /// <summary>Whether actual interpreter results match all saved expectations. Mapping or document evaluation errors never satisfy negative expectations.</summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Total evaluated interpreter checks, including checks omitted from the bounded preview.</summary>
    [JsonPropertyName("checkCount")]
    [JsonRequired]
    public int CheckCount { get; set; } = default!;

    /// <summary>Bounded preview, non-passing checks first. Contains no raw inputs, outputs, fact values, or engine error text.</summary>
    [JsonPropertyName("checks")]
    [JsonRequired]
    public List<ConfigurationScenarioCaseCheck> Checks { get; set; } = default!;

    /// <summary>Actual offline interpreter outcome; null when evaluation could not run.</summary>
    [JsonPropertyName("actualOutcome")]
    [JsonRequired]
    public string? ActualOutcome { get; set; } = default!;

    /// <summary>Hash of all actual check IDs, outcomes, and codes; null on evaluation errors.</summary>
    [JsonPropertyName("actualChecksSha256")]
    [JsonRequired]
    public string? ActualChecksSha256 { get; set; } = default!;

    /// <summary>Safe diagnostic category, or null when the saved test passed.</summary>
    [JsonPropertyName("diagnosticCode")]
    [JsonRequired]
    public string? DiagnosticCode { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
