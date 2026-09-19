# ModernEDI .NET SDK

A server-side C# client for the [ModernEDI Integration API](https://www.modernedi.com/integration-api/).
It targets .NET 8 and newer, uses `HttpClient` and `System.Text.Json`, and has no external runtime
package dependencies.

**Preview 0.2.0:** the API may evolve before 1.0. Install the official package from NuGet:

```sh
dotnet add package ModernEdi --version 0.2.0
```

## Get started

Create a scoped Integration API key in your workspace and keep it in a server-side secret store.
Do not embed it in browser, desktop, or mobile distributions, Git, or logs. See
[Integration API authentication](https://www.modernedi.com/integration-api/).

```csharp
using ModernEdi;

using var client = new ModernEdiClient(
    apiKey: Environment.GetEnvironmentVariable("MODERNEDI_API_KEY")
        ?? throw new InvalidOperationException("Set MODERNEDI_API_KEY."));
var response = await client.Partners.ListIntegrationPartnersAsync();
Console.WriteLine($"Support request ID: {response.RequestId}");
```

One mapping is enough to process a document with a partner. Scenarios and Git are optional:
scenarios verify conversations, while configuration-as-code reviews and deploys those same maps,
partner settings, and optional scenario resources. They do not introduce a second mapping runtime.

API groups match the TypeScript SDK: `Partners`, `Mappings`, `MappedOutputs`, `Transactions`,
`OutboundAs2`, `As2Connections`, `ConfigurationAsCode`, `ScenarioRuns`, `MappingRuntime`,
`IntegrationEvents`, `Account`, and `X12`. Methods end in `Async` and accept a `CancellationToken`.
Their parameters and models are generated from the canonical OpenAPI contract.

Reuse one client for connection pooling. SDK-owned HTTP clients do not follow redirects. An
injected `HttpClient` remains caller-owned: configure its handler with `AllowAutoRedirect=false`
and do not put authentication in default headers. The SDK requires exactly one `apiKey` or
`bearerToken`. HTTPS and standard certificate validation are the defaults; custom `baseUrl`
allows plain HTTP only for loopback tests. The default operation timeout, including retries,
is 30 seconds. Caller cancellation is honored during requests and backoff.
`bearerToken` sends the same Integration API key as `Authorization: Bearer`; it is not a
browser sign-in session token.

## Typed models and configuration

```csharp
using ModernEdi.Model;

var exported = (await client.ConfigurationAsCode.ExportIntegrationConfigurationAsync()).Data
    ?? throw new InvalidOperationException("Expected an unconditional export.");
var request = new ConfigurationPlanRequest
{
    Files = exported.Files.Select(file => new ConfigurationPlanFile(file)).ToList()
};
var planned = await client.ConfigurationAsCode.PlanIntegrationConfigurationAsync(request);
```

This only plans: it changes no configuration and sends no EDI. Apply is a separate, explicit
operation requiring the reviewed plan, current snapshot precondition, and an idempotency key.
See [configuration-as-code](https://www.modernedi.com/integration-api/#tag/Configuration-as-Code) and the
[read-only example](examples/ConfigurationPlan/Program.cs).

Use `WireJson.Serialize()`/`Deserialize<T>()` for model wire data. Generated properties carry
their wire names. Optional fields use `Optional<T>`: an unset field is omitted, while setting
`new Optional<T>(null)` retains explicit null when the schema allows it. False and zero are not
dropped. Response extension fields are retained. Timestamps remain strings to preserve all nine
fractional digits. Server-side validation remains authoritative.

C# has no built-in JSON union type. Union models such as `ConfigurationPlanFile` and
`ConfigurationResourceDocument` therefore retain their original `JsonElement`. Use `.As<T>()`
to read a documented variant, then construct a new union from the edited model; modifying the
returned model does not mutate the original union. This preserves configuration source, hashes,
polymorphic scenario resources, and numbers without guessing which union member to serialize.
Test/Production bindings and omitted syntax-tree pins use the existing server semantics.

## Source bodies and mapped outputs

```csharp
var xml = RequestBody.Text("<invoice><number>INV-1</number></invoice>", "application/xml");
var envelope = RequestBody.Json(new {
    input = "<invoice/>", contentType = "application/xml",
    @params = new { invoiceNumber = "INV-1" }
}, "application/vnd.modernedi.outbound+json");
```

Pass an explicit `RequestBody` to the outbound methods accepting multiple media types. XML/text
are not JSON-quoted. Ordinary send/reply methods apply an outgoing map; the generated-X12 methods
are for applications already holding X12. `test: true` selects the partner's Test AS2 configuration
but still sends real test traffic. Supply live map parameters in the envelope, not Mapper fixtures.
Only acknowledge a mapped output after your integration has durably stored or enqueued it.

## Responses, errors, and safe retries

Every operation returns `ApiResponse<T>` with `Data`, `StatusCode`, `Headers`, exact `RawBody`,
`RequestId`, `ETag`, `Location`, `RetryAfter`, `IdempotencyReplayed`, and `ContentSha256`.
Hash `RawBody` when checking scenario evidence, not re-serialized models. Conditional `304`
responses have no data.

`ModernEdiApiException` exposes `StatusCode`, `Code`, `RequestId`, `Retryable`, `Details`,
`RetryAfter`, and `RawBody`. Non-JSON HTTP errors still retain status/correlation information.
Raw responses can contain sensitive partner documents; do not log them indiscriminately.

Retries are off by default. Opt in with `retry: new RetryOptions { MaxAttempts = 3 }`.
Only transport failures and HTTP 429/502/503/504 retry. Safe reads, read-only configuration plans,
and watch/unwatch operations need no idempotency key; other mutations must support and supply one
in the API contract. Adding the header to an unsupported operation does not enable retries. `Retry-After` is never
shortened: if it exceeds `MaxDelay`, the exception is returned so your application can schedule
another attempt. `RequestOptions` carries per-call headers and timeout overrides.

`Pagination.CursorAsync` takes page-loading, item, and next-cursor functions. It preserves opaque
cursors, detects cycles, honors cancellation, and defaults to a 1,000-page maximum. Repeat all
filters on every page and lower `maxPages` to bound your workflow.

Use `Pagination.MappedOutputsAsync` for the lease-acquiring mapped-output queue:

```csharp
await foreach (var output in Pagination.MappedOutputsAsync(
    (cursor, token) => client.MappedOutputs.PollMappedOutputsAsync(
        cursor: cursor, environment: "test", cancellationToken: token), maxPolls: 20))
{
    // Durably save/deduplicate output.Id, then acknowledge its latest ReceiptHandle.
    Console.WriteLine(output.Id);
}
```

Repeated cursors are valid for queue polls; empty pages with a cursor continue the scan.
The helper stops at the end of the scan or `maxPolls` (default 1,000) and honors cancellation.
It does not acknowledge, deduplicate, or continuously watch. Queue polls are never
automatically retried because a lost response can already have acquired leases; those
outputs become available again after the visibility timeout. Single-output acknowledgment
details are under `response.Data.Acknowledgment`, not duplicated at the top level.
Conditional configuration export returns status `304` with `Data == null` and the ETag
when unchanged; this is a normal result, not an exception.

## Webhooks

```csharp
var webhook = Webhooks.VerifyMappedOutput(rawBody, requestHeaders, signingSecret);
```

Pass original request bytes and all header values before parsing JSON. Verification uses
HMAC-SHA-256, constant-time comparison, a five-minute timestamp tolerance, duplicate-header
rejection, event-shape checks, and matching header/body identity. Failures expose
`WebhookVerificationException.Code`.

After verification, durably deduplicate `deliveryId` and, for business processing, `message.id`:
a legitimate redelivery gets a new delivery ID. Signature verification does not prove ERP acceptance.

No Git provider login, hosted workflow, or code generator is needed by consumers.

## Build and test this repository

This is complete, standalone package source with offline tests and synthetic fixtures.
No ModernEDI account, private repository, API key, or generator is needed.

```sh
dotnet test tests/ModernEdi.Tests/ModernEdi.Tests.csproj
dotnet pack src/ModernEdi/ModernEdi.csproj -c Release
```

Generated API files come from ModernEDI's canonical contract. Please report issues here;
changes are made upstream and exported as reviewed snapshots. PUBLIC_SOURCE.json records
the exact source revision and hashes. Normal CI never publishes or calls your workspace.
