// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Publication state for a committed partner, AS2 connection, mapping, or aggregate configuration mutation. This field is not returned by ordinary reads or webhook configuration changes.</summary>

public sealed class RuntimePublication
{
    /// <summary>- &#x60;published&#x60;: the tenant runtime configuration was published successfully, either inline during rollout or by updating its external configuration pointer. - &#x60;pending&#x60;: the database mutation committed, but runtime publication failed. ModernEDI&#39;s reconciler retries automatically. - &#x60;not_provisioned&#x60;: the tenant does not have runtime infrastructure yet, so there is no runtime context to publish. </summary>
    [JsonPropertyName("state")]
    [JsonRequired]
    public string State { get; set; } = default!;

    /// <summary>True while the reconciler will continue retrying a pending publication.</summary>
    [JsonPropertyName("retrying")]
    [JsonRequired]
    public bool Retrying { get; set; } = default!;

    /// <summary>Optional safe operational context when publication is pending or not provisioned.</summary>
    [JsonPropertyName("message")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> Message { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
