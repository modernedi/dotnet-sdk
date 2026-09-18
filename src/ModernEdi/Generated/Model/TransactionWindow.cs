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

public sealed class TransactionWindow
{
    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;.</summary>
    [JsonPropertyName("startDate")]
    [JsonRequired]
    public string StartDate { get; set; } = default!;

    /// <summary>UTC RFC 3339 instant with exactly nine fractional digits and a trailing &#x60;Z&#x60;.</summary>
    [JsonPropertyName("endDate")]
    [JsonRequired]
    public string EndDate { get; set; } = default!;

    /// <summary>Time zone used for transaction timestamps and normalized query windows.</summary>
    [JsonPropertyName("timeZone")]
    [JsonRequired]
    public string VarTimeZone { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
