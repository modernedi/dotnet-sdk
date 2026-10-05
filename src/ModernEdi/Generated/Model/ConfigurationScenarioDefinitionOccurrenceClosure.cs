// Generated from the ModernEDI Integration API 1.36.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>The rule that tells a run no more documents will be attached to a step. fixed closes at the fixed count; max_reached closes at the maximum; expected_count uses a required or defaulted count parameter. explicit waits for an authorized browser or API decision, even at max: advance with closeSteps records the exact attached count and time, then evaluates all existing checks. Closing does not assert success, reopen the step, or send EDI. An explicit min-zero step can close with no documents. Existing attachments may still refresh pending evidence while the run is active. A new run is required for additional documents after closure. Branch selection supplies the no-document outcome for an unselected destination.</summary>
[JsonConverter(typeof(JsonValueConverterFactory))]
public sealed class ConfigurationScenarioDefinitionOccurrenceClosure : JsonValue
{
    public ConfigurationScenarioDefinitionOccurrenceClosure(JsonElement value) : base(value) { }
    public ConfigurationScenarioDefinitionOccurrenceClosure(object value) : base(value) { }
}
