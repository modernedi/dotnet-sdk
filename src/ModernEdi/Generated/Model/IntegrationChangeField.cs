// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary>Stable public transaction component whose fingerprint changed.</summary>

[JsonConverter(typeof(WireEnumConverterFactory))]
public enum IntegrationChangeField
{

    [EnumMember(Value = "transaction")]
    Transaction,

    [EnumMember(Value = "mappingStatus")]
    MappingStatus,

    [EnumMember(Value = "functionalAcknowledgment")]
    FunctionalAcknowledgment,

    [EnumMember(Value = "implementationAcknowledgment")]
    ImplementationAcknowledgment,

    [EnumMember(Value = "technicalAcknowledgment")]
    TechnicalAcknowledgment,

    [EnumMember(Value = "mdn")]
    Mdn,

    [EnumMember(Value = "mappedOutputs")]
    MappedOutputs,

    [EnumMember(Value = "attention")]
    Attention

}
