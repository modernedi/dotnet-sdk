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

public sealed class OutboundTransformEnvelope
{
    /// <summary>Content type of &#x60;input&#x60; and the outgoing map to select. Use this envelope with HTTP &#x60;Content-Type: application/vnd.modernedi.outbound+json&#x60; when the source input is XML, text, or JSON with extra transform params. Ordinary &#x60;application/json&#x60; is always treated as the source document itself. </summary>
    [JsonPropertyName("contentType")]
    [JsonRequired]
    public string ContentType { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("input")]
    [JsonRequired]
    public OutboundTransformEnvelopeInput Input { get; set; } = default!;

    /// <summary>Optional business identifier to store on the outbound transaction record, such as an invoice number, ASN number, BOL number, shipment id, or other value your system uses for reconciliation. This is recorded for transaction search and display only; it does not affect outgoing-map selection or transform execution. </summary>
    [JsonPropertyName("businessKey")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<OutboundBusinessKey> BusinessKey { get; set; }

    /// <summary>Optional transform parameters. For XSLT maps, each key is bound as an external stylesheet parameter with the same simple, unqualified name. &#x60;json&#x60; and &#x60;text&#x60; are reserved by ModernEDI. JSON strings map to &#x60;xs:string&#x60;, integers to integer numbers, decimals to decimal numbers, booleans to &#x60;xs:boolean&#x60;, null to an empty sequence, objects to &#x60;map(xs:string, item()*)&#x60;, and arrays to XDM sequences. Arrays of objects therefore work with declarations such as &#x60;&lt;xsl:param name&#x3D;\&quot;pallets\&quot; as&#x3D;\&quot;map(xs:string, xs:anyAtomicType)*\&quot; required&#x3D;\&quot;yes\&quot;/&gt;&#x60;. JSLT still uses &#x60;.&#x60; as its current input, but for JSLT maps ModernEDI evaluates the map with a root wrapper object shaped as &#x60;{ \&quot;input\&quot;: &lt;source&gt;, \&quot;params\&quot;: &lt;params&gt; }&#x60;. Source fields are therefore read as &#x60;.input.invoice.number&#x60; instead of directly from the root, and params are read as &#x60;.params.bolNumber&#x60;, &#x60;.params.pallets[0]&#x60;, and so on. When JSLT repeated output needs params inside a &#x60;for&#x60; loop, bind &#x60;.params&#x60; before the loop, such as &#x60;let params &#x3D; .params&#x60;, and read &#x60;$params.bolNumber&#x60; inside the loop because &#x60;.&#x60; is the current source item there. Use &#x60;required&#x3D;\&quot;yes\&quot;&#x60; for XSLT params that every live request must supply. Params JSON files in the mapper editor are used only for test-running a map; they are not live defaults for this API. In the mapper editor, params are standalone JSON fixture files that can be edited like other workspace files and selected when test-running the map. While authoring JSLT, the editor uses the selected source and params fixture files for completions, diagnostics, and quick fixes for wrapper root mistakes, missing sample paths, and &#x60;get-key&#x60; object-key typos. </summary>
    [JsonPropertyName("params")]

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<Dictionary<string, Object>> Params { get; set; }

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
