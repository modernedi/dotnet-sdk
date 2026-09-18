// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Parsed TA1 interchange-level result. Only &#x60;received&#x60; is a clean outcome; every other received status requires operator review.</summary>

public sealed class TechnicalAcknowledgmentOutcome
{
    /// <summary>Normalized TA104 result. &#x60;A&#x60; becomes &#x60;received&#x60;, &#x60;E&#x60; becomes &#x60;received_with_errors&#x60;, and &#x60;R&#x60; becomes &#x60;rejected&#x60;.</summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary>Customer-readable interpretation of the TA104 outcome.</summary>
    [JsonPropertyName("summary")]
    [JsonRequired]
    public string Summary { get; set; } = default!;

    /// <summary>True when ModernEDI found a structurally usable TA1 segment and recognized TA104.</summary>
    [JsonPropertyName("parsed")]
    [JsonRequired]
    public bool Parsed { get; set; } = default!;

    /// <summary>Raw TA104 interchange acknowledgment code (&#x60;A&#x60;, &#x60;E&#x60;, or &#x60;R&#x60;) when available.</summary>
    [JsonPropertyName("acknowledgmentCode")]
    [JsonRequired]
    public string? AcknowledgmentCode { get; set; } = default!;

    /// <summary>Raw TA105 interchange note/error code. Interpret it with the partner&#39;s X12 implementation guidance; &#x60;000&#x60; normally accompanies a clean acceptance.</summary>
    [JsonPropertyName("errorCode")]
    [JsonRequired]
    public string? ErrorCode { get; set; } = default!;

    /// <summary>TA101 control number identifying the original ISA13 interchange acknowledged by this TA1.</summary>
    [JsonPropertyName("acknowledgedInterchangeControlNumber")]
    [JsonRequired]
    public string? AcknowledgedInterchangeControlNumber { get; set; } = default!;

    /// <summary>Stable reason &#x60;status&#x60; is &#x60;unknown&#x60;, or &#x60;null&#x60; for a recognized outcome.</summary>
    [JsonPropertyName("unknownReason")]
    [JsonRequired]
    public string? UnknownReason { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
