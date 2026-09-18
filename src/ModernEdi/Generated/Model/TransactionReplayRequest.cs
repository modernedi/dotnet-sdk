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

public sealed class TransactionReplayRequest
{
    /// <summary></summary>
    [JsonPropertyName("environment")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> VarEnvironment { get; set; }

    /// <summary>Uses the mappings currently published for the partner. This is the only public replay mode.</summary>
    [JsonPropertyName("mode")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> Mode { get; set; }

    /// <summary>Regenerated outputs are returned only; no queue item, webhook, or outbound acknowledgment is produced.</summary>
    [JsonPropertyName("delivery")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> Delivery { get; set; }

    /// <summary>Optional operator or automation context recorded on the replay attempt.</summary>
    [JsonPropertyName("reason")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string?> Reason { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
