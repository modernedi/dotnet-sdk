// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>One persisted mapping execution result with source revision, diagnostic location, replay linkage, and resolution state.</summary>

public sealed class TransactionMappingAttempt
{
    /// <summary>ModernEDI correlation id for the mapping operation. For a normal transaction-backed attempt this is the AS2 Message-Id. For a pre-transaction outbound failure it is an opaque request correlation id and must not be presented as an AS2 Message-Id. </summary>
    [JsonPropertyName("correlationId")]
    [JsonRequired]
    public string CorrelationId { get; set; } = default!;

    /// <summary>Opaque identifier for this individual mapping execution attempt.</summary>
    [JsonPropertyName("attemptId")]
    [JsonRequired]
    public string AttemptId { get; set; } = default!;

    /// <summary>Source transaction key shown in the transaction viewer. Pre-transaction outbound failures use the sentinel &#x60;outbound-request&#x60;; internal mapping-attempt persistence keys are never exposed. </summary>
    [JsonPropertyName("transactionKey")]
    [JsonRequired]
    public string TransactionKey { get; set; } = default!;

    /// <summary>Whether this attempt processed inbound X12 or generated outbound X12.</summary>
    [JsonPropertyName("direction")]
    [JsonRequired]
    public string Direction { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("environment")]
    [JsonRequired]
    public string VarEnvironment { get; set; } = default!;

    /// <summary>Whether the attempted map hash is still the currently published revision.</summary>
    [JsonPropertyName("currentRevision")]
    [JsonRequired]
    public bool CurrentRevision { get; set; } = default!;

    /// <summary>Mapping pipeline stage that produced the result.</summary>
    [JsonPropertyName("stage")]
    [JsonRequired]
    public string Stage { get; set; } = default!;

    /// <summary>Whether this individual mapping attempt succeeded or failed.</summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Stable machine-readable mapping result code.</summary>
    [JsonPropertyName("code")]
    [JsonRequired]
    public string Code { get; set; } = default!;

    /// <summary>Fallback behavior used after this attempt, or &#x60;NONE&#x60;.</summary>
    [JsonPropertyName("fallback")]
    [JsonRequired]
    public string Fallback { get; set; } = default!;

    /// <summary>UTC instant when this mapping attempt was recorded.</summary>
    [JsonPropertyName("timestamp")]
    [JsonRequired]
    public string Timestamp { get; set; } = default!;

    /// <summary>Whether a later successful attempt has resolved this failure for operator-attention purposes.</summary>
    [JsonPropertyName("resolved")]
    [JsonRequired]
    public bool Resolved { get; set; } = default!;

    /// <summary>Transaction that owns this attempt, or &#x60;null&#x60; when mapping failed before ModernEDI could create a transaction. </summary>
    [JsonPropertyName("transactionReference")]
    [JsonRequired]
    public MappingRuntimeTransactionReference? TransactionReference { get; set; } = default!;

    /// <summary>Opaque identifier for correlating and retrieving a failed attempt. This is &#x60;null&#x60; for successful attempts because the failure-detail endpoint intentionally exposes only retained failures. </summary>
    [JsonPropertyName("failureId")]
    [JsonRequired]
    public string? FailureId { get; set; } = default!;

    /// <summary>Partner name captured at execution time, or &#x60;null&#x60; when attribution was unavailable.</summary>
    [JsonPropertyName("partnerName")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> PartnerName { get; set; }

    /// <summary>Stable workspace-scoped partner id, or &#x60;null&#x60; when the attempt could not be attributed.</summary>
    [JsonPropertyName("partnerId")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int?> PartnerId { get; set; }

    /// <summary>Workspace-scoped mapping id, or &#x60;null&#x60; when no published map was resolved.</summary>
    [JsonPropertyName("mappingId")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int?> MappingId { get; set; }

    /// <summary>Transform filename attempted, or &#x60;null&#x60; when selection failed before a file was resolved.</summary>
    [JsonPropertyName("mapFile")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> MapFile { get; set; }

    /// <summary>Base64 SHA-256 hash of the transform source actually attempted, or &#x60;null&#x60; when unavailable.</summary>
    [JsonPropertyName("mapFileSha256Hash")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> MapFileSha256Hash { get; set; }

    /// <summary>Base64 SHA-256 hash of the currently published source, or &#x60;null&#x60; when it cannot be resolved.</summary>
    [JsonPropertyName("currentMapFileSha256Hash")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> CurrentMapFileSha256Hash { get; set; }

    /// <summary>ST01 transaction-set identifier associated with the attempt, or &#x60;null&#x60; when unknown.</summary>
    [JsonPropertyName("transactionSetIdentifierCode")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> TransactionSetIdentifierCode { get; set; }

    /// <summary>ST02 transaction control number associated with the attempt, or &#x60;null&#x60; when unknown.</summary>
    [JsonPropertyName("transactionControlNumber")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> TransactionControlNumber { get; set; }

    /// <summary>GS01 functional identifier associated with the attempt, or &#x60;null&#x60; when unknown.</summary>
    [JsonPropertyName("functionalIdentifierCode")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> FunctionalIdentifierCode { get; set; }

    /// <summary>GS06 functional-group control number associated with the attempt, or &#x60;null&#x60; when unknown.</summary>
    [JsonPropertyName("functionalGroupControlNumber")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> FunctionalGroupControlNumber { get; set; }

    /// <summary>X12 implementation version used by the attempt, or &#x60;null&#x60; when unresolved.</summary>
    [JsonPropertyName("x12Version")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> X12Version { get; set; }

    /// <summary>Sanitized diagnostic message safe to display to workspace operators.</summary>
    [JsonPropertyName("safeMessage")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> SafeMessage { get; set; }

    /// <summary>One-based source line for a transform diagnostic, or &#x60;null&#x60; when no precise location exists.</summary>
    [JsonPropertyName("line")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int?> Line { get; set; }

    /// <summary>One-based source column for a transform diagnostic, or &#x60;null&#x60; when no precise location exists.</summary>
    [JsonPropertyName("column")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<int?> Column { get; set; }

    /// <summary>Replay operation id that created this attempt, or &#x60;null&#x60; for ordinary processing.</summary>
    [JsonPropertyName("replayId")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> ReplayId { get; set; }

    /// <summary>Original failed attempt targeted by this replay, or &#x60;null&#x60; when the attempt was not a replay.</summary>
    [JsonPropertyName("replayOfAttemptId")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> ReplayOfAttemptId { get; set; }

    /// <summary>UTC instant when the failure was resolved, or &#x60;null&#x60; while unresolved or not applicable.</summary>
    [JsonPropertyName("resolvedAt")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> ResolvedAt { get; set; }

    /// <summary>Successful attempt id that resolved this failure, or &#x60;null&#x60; while unresolved or not applicable.</summary>
    [JsonPropertyName("resolvedByAttemptId")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> ResolvedByAttemptId { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
