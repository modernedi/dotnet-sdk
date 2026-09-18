// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary></summary>

public sealed class FunctionalAcknowledgmentTransactionSetOutcome
{
    /// <summary></summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Non-empty AK502 and later transaction-set syntax error codes.</summary>
    [JsonPropertyName("errorCodes")]
    [JsonRequired]
    public List<string> ErrorCodes { get; set; } = default!;

    /// <summary>AK101 functional identifier code for the acknowledged group, such as &#x60;PO&#x60; or &#x60;IN&#x60;.</summary>
    [JsonPropertyName("functionalIdentifierCode")]
    [JsonRequired]
    public string? FunctionalIdentifierCode { get; set; } = default!;

    /// <summary>AK102 control number for the acknowledged functional group.</summary>
    [JsonPropertyName("functionalGroupControlNumber")]
    [JsonRequired]
    public string? FunctionalGroupControlNumber { get; set; } = default!;

    /// <summary>AK201 transaction set identifier code, such as &#x60;850&#x60; or &#x60;810&#x60;.</summary>
    [JsonPropertyName("transactionSetIdentifierCode")]
    [JsonRequired]
    public string? TransactionSetIdentifierCode { get; set; } = default!;

    /// <summary>AK202 transaction set control number.</summary>
    [JsonPropertyName("transactionSetControlNumber")]
    [JsonRequired]
    public string? TransactionSetControlNumber { get; set; } = default!;

    /// <summary>Raw AK203 implementation convention reference, or &#x60;null&#x60; when the sender omitted it; it is retained without claiming implementation-guide certification.</summary>
    [JsonPropertyName("implementationConventionReference")]
    [JsonRequired]
    public string? ImplementationConventionReference { get; set; } = default!;

    /// <summary>Original AK501 transaction-set acknowledgment code, when available. This raw code is preserved independently from &#x60;status&#x60;: AK501 &#x60;A&#x60; normalizes to &#x60;accepted_with_errors&#x60; when its AK2 loop reports AK3/AK4 detail or non-empty AK502 and later syntax-error codes. Only a normalized &#x60;accepted&#x60; status is clean. </summary>
    [JsonPropertyName("acknowledgmentCode")]
    [JsonRequired]
    public string? AcknowledgmentCode { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
