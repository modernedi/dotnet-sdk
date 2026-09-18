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

public sealed class ImplementationAcknowledgmentTransactionSetOutcome
{
    /// <summary></summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Non-empty IK502 and later transaction-set syntax error codes.</summary>
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

    /// <summary>AK201 transaction-set identifier code, such as &#x60;850&#x60; or &#x60;810&#x60;.</summary>
    [JsonPropertyName("transactionSetIdentifierCode")]
    [JsonRequired]
    public string? TransactionSetIdentifierCode { get; set; } = default!;

    /// <summary>AK202 transaction-set control number.</summary>
    [JsonPropertyName("transactionSetControlNumber")]
    [JsonRequired]
    public string? TransactionSetControlNumber { get; set; } = default!;

    /// <summary>Raw AK203 implementation-convention reference echoed from the acknowledged ST03, or &#x60;null&#x60; when absent.</summary>
    [JsonPropertyName("implementationConventionReference")]
    [JsonRequired]
    public string? ImplementationConventionReference { get; set; } = default!;

    /// <summary>Original IK501 transaction-set acknowledgment code, when available. This raw code is preserved separately from normalized &#x60;status&#x60;; bare IK501 &#x60;A&#x60; is inconsistent and normalizes to &#x60;unknown&#x60; when its AK2 loop also reports IK3/IK4 error detail. </summary>
    [JsonPropertyName("acknowledgmentCode")]
    [JsonRequired]
    public string? AcknowledgmentCode { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
