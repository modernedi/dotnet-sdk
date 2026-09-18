// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Machine-readable reason that a transaction needs operator attention. &#x60;functional_ack_issue&#x60; means a 997 was received but was not cleanly accepted. &#x60;implementation_ack_issue&#x60; means a 999 was received but the transaction-specific IK5 result or conservative AK9 group result was not cleanly accepted. &#x60;x12_ack_overdue&#x60; means neither a 997 nor a 999 was received for an eligible outbound business transaction by &#x60;x12AcknowledgmentExpectedBy&#x60;; outbound 997 and 999 acknowledgment documents are excluded. The overdue signal does not automatically resend the original X12. &#x60;technical_ack_issue&#x60; means a requested TA1 was received but rejected the interchange, reported errors, or could not be classified. &#x60;technical_ack_overdue&#x60; means ISA14 requested a TA1 but none was received by &#x60;technicalAckExpectedBy&#x60;. Neither technical-acknowledgment reason automatically resends the original X12. &#x60;as2_mdn_attention&#x60; means the partner&#39;s AS2 receipt is overdue, rejected, invalid, contains a warning, or its returned content MIC does not match the content ModernEDI sent. ModernEDI never automatically resends a document in response to an MDN issue because the partner may already have processed it. &#x60;mapped_output_not_collected&#x60; means a managed output remained available beyond the 15-minute pickup grace period without a first delivery lease. &#x60;mapped_output_ack_overdue&#x60; means a delivered output was not acknowledged before its lease expired or was delivered more than once. One transaction can have more than one active reason. </summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum TransactionAttentionReason
{

    [EnumMember(Value = "mapping_failure")]
    MappingFailure,

    [EnumMember(Value = "functional_ack_issue")]
    FunctionalAckIssue,

    [EnumMember(Value = "implementation_ack_issue")]
    ImplementationAckIssue,

    [EnumMember(Value = "x12_ack_overdue")]
    X12AckOverdue,

    [EnumMember(Value = "technical_ack_issue")]
    TechnicalAckIssue,

    [EnumMember(Value = "technical_ack_overdue")]
    TechnicalAckOverdue,

    [EnumMember(Value = "as2_mdn_attention")]
    As2MdnAttention,

    [EnumMember(Value = "mapped_output_not_collected")]
    MappedOutputNotCollected,

    [EnumMember(Value = "mapped_output_ack_overdue")]
    MappedOutputAckOverdue,

    [EnumMember(Value = "watchlist")]
    Watchlist

}
