// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>An exact-output test for the existing Mapper engines. Whitespace, line endings, ordering, and delimiters are significant. Incoming X12 Mapper requires application/edi-x12 and null params; its zero-based group and transaction selectors may be null. Outgoing JSLT/XSLT requires JSON/XML input and null selectors; params is an object or null. Outgoing cases may additionally select validateX12 to check the generated document against the mapping&#39;s X12 specification using the normal preview/send envelope preparation. No execution results or timestamps belong in this source document. </summary>

public sealed class MappingRegressionCase
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public string Id { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("comparison")]
    [JsonRequired]
    public string Comparison { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("input")]
    [JsonRequired]
    public string Input { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("contentType")]
    [JsonRequired]
    public string ContentType { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("expectedOutput")]
    [JsonRequired]
    public string ExpectedOutput { get; set; } = default!;

    /// <summary>Optional outgoing-only document validation in addition to exact-text comparison. Defaults to false when omitted. Complete document bodies are wrapped for validation; partial fragments need not opt in. Does not send EDI or prove business correctness or partner acceptance.</summary>
    [JsonPropertyName("validateX12")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> ValidateX12 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("params")]
    [JsonRequired]
    public Dictionary<string, Object>? Params { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("functionalGroupIndex")]
    [JsonRequired]
    public int? FunctionalGroupIndex { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("transactionIndex")]
    [JsonRequired]
    public int? TransactionIndex { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
