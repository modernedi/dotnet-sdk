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

public sealed class AdvanceScenarioRunRequest
{
    /// <summary>Optional explicit no-more-documents decision. Only reachable open steps declared with closure.kind&#x3D;explicit are eligible. Their exact attached counts and server time are recorded atomically with the result and actor-attributed operation. All business and evidence checks still apply; incomplete fulfillment can fail. New documents cannot be attached after closure, but existing observations can refresh pending evidence while the run remains active. This action never dispatches EDI and needs no messages:write scope or supplemental x-api-key. It cannot bypass an expired deadline. For an ambiguous response retry the same list, If-Match and Idempotency-Key.</summary>
    [JsonPropertyName("closeSteps")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<List<string>> CloseSteps { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
