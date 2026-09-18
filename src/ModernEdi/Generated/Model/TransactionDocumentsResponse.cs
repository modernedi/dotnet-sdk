// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Metadata index of documents retained for one transaction, including X12, mapped outputs, acknowledgments, and HTTP response artifacts.</summary>

public sealed class TransactionDocumentsResponse
{
    /// <summary>Always &#x60;true&#x60;; unknown transactions or authorization failures use an error response.</summary>
    [JsonPropertyName("success")]
    [JsonRequired]
    public bool Success { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary>Retained document metadata in display order. Fetch an individual document to obtain its body.</summary>
    [JsonPropertyName("documents")]
    [JsonRequired]
    public List<TransactionDocumentMetadata> Documents { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
