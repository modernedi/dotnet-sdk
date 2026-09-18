// Generated from the complete bundled Integration API. Do not edit.
#nullable enable
using System.Text.Json;
using ModernEdi.Model;
namespace ModernEdi;

public sealed partial class ModernEdiClient
{
    public MappedOutputQueueApi MappedOutputs => new(this);
    public ScenarioRunsApi ScenarioRuns => new(this);
    public ConfigurationAsCodeApi ConfigurationAsCode => new(this);
    public OutboundAS2Api OutboundAs2 => new(this);
    public AS2ConnectionsApi As2Connections => new(this);
    public PartnersApi Partners => new(this);
    public MappingsApi Mappings => new(this);
    public MappingRuntimeApi MappingRuntime => new(this);
    public TransactionViewerApi Transactions => new(this);
    public AccountApi Account => new(this);
    public IntegrationEventsApi IntegrationEvents => new(this);
    public X12ToolsApi X12 => new(this);
}

public sealed class MappedOutputQueueApi
{
    private readonly ModernEdiClient client;
    internal MappedOutputQueueApi(ModernEdiClient client) { this.client = client; }

    /// <summary>Mark mapped output as received</summary>
    public Task<ApiResponse<MappedOutputAckResponse>> AcknowledgeMappedOutputAsync(MappedOutputAckRequest body, string id, string? xRequestId = null, string? environment = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<MappedOutputAckResponse>("acknowledgeMappedOutput", "POST", "/v1/mapped-outputs/{id}/ack",
            new Dictionary<string, object?> { ["id"] = id },
            new Dictionary<string, object?> { ["environment"] = environment },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            RequestBody.Json(body), options, cancellationToken);

    /// <summary>Atomically acknowledge multiple mapped outputs</summary>
    public Task<ApiResponse<MappedOutputBulkAckResponse>> AcknowledgeMappedOutputsAsync(MappedOutputBulkAckRequest body, string? xRequestId = null, string? environment = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<MappedOutputBulkAckResponse>("acknowledgeMappedOutputs", "POST", "/v1/mapped-outputs/ack",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["environment"] = environment },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            RequestBody.Json(body), options, cancellationToken);

    /// <summary>Get mapped-output webhook status</summary>
    public Task<ApiResponse<MappedOutputWebhookStatusResponse>> GetMappedOutputWebhookStatusAsync(int partnerId, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<MappedOutputWebhookStatusResponse>("getMappedOutputWebhookStatus", "GET", "/v1/partners/{partnerId}/mapped-output-webhook",
            new Dictionary<string, object?> { ["partnerId"] = partnerId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Poll mapped inbound output</summary>
    public Task<ApiResponse<MappedOutputQueueResponse>> PollMappedOutputsAsync(string? xRequestId = null, string? environment = null, string? startDate = null, string? endDate = null, string? cursor = null, int? limit = null, int? visibilityTimeoutSeconds = null, string? direction = null, string? partnerName = null, int? partnerId = null, string? transactionSet = null, string? businessKey = null, string? messageId = null, string? replyToMessageId = null, string? transactionControlNumber = null, string? functionalGroupControlNumber = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<MappedOutputQueueResponse>("pollMappedOutputs", "GET", "/v1/mapped-outputs",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["environment"] = environment, ["startDate"] = startDate, ["endDate"] = endDate, ["cursor"] = cursor, ["limit"] = limit, ["visibilityTimeoutSeconds"] = visibilityTimeoutSeconds, ["direction"] = direction, ["partnerName"] = partnerName, ["partnerId"] = partnerId, ["transactionSet"] = transactionSet, ["businessKey"] = businessKey, ["messageId"] = messageId, ["replyToMessageId"] = replyToMessageId, ["transactionControlNumber"] = transactionControlNumber, ["functionalGroupControlNumber"] = functionalGroupControlNumber },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Send a synthetic mapped-output webhook test</summary>
    public Task<ApiResponse<MappedOutputWebhookTestResponse>> TestMappedOutputWebhookAsync(int partnerId, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<MappedOutputWebhookTestResponse>("testMappedOutputWebhook", "POST", "/v1/partners/{partnerId}/mapped-output-webhook/test",
            new Dictionary<string, object?> { ["partnerId"] = partnerId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Configure mapped-output webhook delivery</summary>
    public Task<ApiResponse<MappedOutputWebhookUpdateResponse>> UpdateMappedOutputWebhookAsync(MappedOutputWebhookUpdateRequest body, int partnerId, string ifMatch, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<MappedOutputWebhookUpdateResponse>("updateMappedOutputWebhook", "PUT", "/v1/partners/{partnerId}/mapped-output-webhook",
            new Dictionary<string, object?> { ["partnerId"] = partnerId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId, ["If-Match"] = ifMatch },
            RequestBody.Json(body), options, cancellationToken);

}

public sealed class ScenarioRunsApi
{
    private readonly ModernEdiClient client;
    internal ScenarioRunsApi(ModernEdiClient client) { this.client = client; }

    /// <summary>Advance adapter work or reevaluate graph deadlines</summary>
    public Task<ApiResponse<ScenarioRunCommandResponse>> AdvanceScenarioRunAsync(JsonElement body, string runId, string idempotencyKey, string ifMatch, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ScenarioRunCommandResponse>("advanceScenarioRun", "POST", "/v1/scenario-runs/{runId}/advance",
            new Dictionary<string, object?> { ["runId"] = runId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["Idempotency-Key"] = idempotencyKey, ["If-Match"] = ifMatch },
            RequestBody.Json(body), options, cancellationToken);

    /// <summary>Attach or refresh a persisted transaction observation</summary>
    public Task<ApiResponse<ScenarioRunCommandResponse>> AttachScenarioRunObservationAsync(ScenarioRunObservationRequest body, string runId, string idempotencyKey, string ifMatch, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ScenarioRunCommandResponse>("attachScenarioRunObservation", "POST", "/v1/scenario-runs/{runId}/observations",
            new Dictionary<string, object?> { ["runId"] = runId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["Idempotency-Key"] = idempotencyKey, ["If-Match"] = ifMatch },
            RequestBody.Json(body), options, cancellationToken);

    /// <summary>Cancel an active scenario run</summary>
    public Task<ApiResponse<ScenarioRunCommandResponse>> CancelScenarioRunAsync(JsonElement body, string runId, string idempotencyKey, string ifMatch, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ScenarioRunCommandResponse>("cancelScenarioRun", "POST", "/v1/scenario-runs/{runId}/cancel",
            new Dictionary<string, object?> { ["runId"] = runId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["Idempotency-Key"] = idempotencyKey, ["If-Match"] = ifMatch },
            RequestBody.Json(body), options, cancellationToken);

    /// <summary>Download the immutable evidence report for a terminal run</summary>
    public Task<ApiResponse<ScenarioEvidenceReport>> DownloadScenarioEvidenceReportAsync(string runId, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ScenarioEvidenceReport>("downloadScenarioEvidenceReport", "GET", "/v1/scenario-runs/{runId}/evidence-report",
            new Dictionary<string, object?> { ["runId"] = runId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            null, options, cancellationToken);

    /// <summary>Read current scenario run state and evidence</summary>
    public Task<ApiResponse<ScenarioRunViewResponse>> GetScenarioRunAsync(string runId, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ScenarioRunViewResponse>("getScenarioRun", "GET", "/v1/scenario-runs/{runId}",
            new Dictionary<string, object?> { ["runId"] = runId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            null, options, cancellationToken);

    /// <summary>Read the actor-attributed operation timeline for a run</summary>
    public Task<ApiResponse<ScenarioRunTimelineResponse>> GetScenarioRunTimelineAsync(string runId, int? limit = null, string? cursor = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ScenarioRunTimelineResponse>("getScenarioRunTimeline", "GET", "/v1/scenario-runs/{runId}/timeline",
            new Dictionary<string, object?> { ["runId"] = runId },
            new Dictionary<string, object?> { ["limit"] = limit, ["cursor"] = cursor },
            new Dictionary<string, object?> {  },
            null, options, cancellationToken);

    /// <summary>List recent scenario conversations</summary>
    public Task<ApiResponse<ScenarioRunCollection>> ListScenarioRunsAsync(int? limit = null, string? cursor = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ScenarioRunCollection>("listScenarioRuns", "GET", "/v1/scenario-runs",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["limit"] = limit, ["cursor"] = cursor },
            new Dictionary<string, object?> {  },
            null, options, cancellationToken);

    /// <summary>Start a run from an exact applied binding</summary>
    public Task<ApiResponse<ScenarioRunCommandResponse>> StartScenarioRunAsync(StartScenarioRunRequest body, string idempotencyKey, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ScenarioRunCommandResponse>("startScenarioRun", "POST", "/v1/scenario-runs",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["Idempotency-Key"] = idempotencyKey },
            RequestBody.Json(body), options, cancellationToken);

}

public sealed class ConfigurationAsCodeApi
{
    private readonly ModernEdiClient client;
    internal ConfigurationAsCodeApi(ModernEdiClient client) { this.client = client; }

    /// <summary>Apply a planned workspace configuration</summary>
    public Task<ApiResponse<ConfigurationApplyOperationResponse>> ApplyIntegrationConfigurationAsync(ConfigurationApplyRequest body, string idempotencyKey, string ifMatch, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ConfigurationApplyOperationResponse>("applyIntegrationConfiguration", "POST", "/v1/configuration/apply",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId, ["Idempotency-Key"] = idempotencyKey, ["If-Match"] = ifMatch },
            RequestBody.Json(body), options, cancellationToken);

    /// <summary>Cancel configuration verification</summary>
    public Task<ApiResponse<ConfigurationVerificationResponse>> CancelIntegrationConfigurationVerificationAsync(string runId, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ConfigurationVerificationResponse>("cancelIntegrationConfigurationVerification", "POST", "/v1/configuration/verification-runs/{runId}/cancel",
            new Dictionary<string, object?> { ["runId"] = runId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Export the current workspace configuration bundle</summary>
    public Task<ApiResponse<ConfigurationExportResponse>> ExportIntegrationConfigurationAsync(string? xRequestId = null, string? ifNoneMatch = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ConfigurationExportResponse>("exportIntegrationConfiguration", "GET", "/v1/configuration/export",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId, ["If-None-Match"] = ifNoneMatch },
            null, options, cancellationToken);

    /// <summary>Select a scenario run from an exact configuration apply</summary>
    public Task<ApiResponse<ConfigurationScenarioRunSelectionResponse>> GetConfigurationScenarioRunSelectionAsync(string operationId, string bindingId, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ConfigurationScenarioRunSelectionResponse>("getConfigurationScenarioRunSelection", "GET", "/v1/configuration/apply-operations/{operationId}/scenario-run-selections/{bindingId}",
            new Dictionary<string, object?> { ["operationId"] = operationId, ["bindingId"] = bindingId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Read verification linked to an apply</summary>
    public Task<ApiResponse<ConfigurationAppliedVerificationResponse>> GetIntegrationConfigurationAppliedVerificationAsync(string operationId, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ConfigurationAppliedVerificationResponse>("getIntegrationConfigurationAppliedVerification", "GET", "/v1/configuration/apply-operations/{operationId}/verification",
            new Dictionary<string, object?> { ["operationId"] = operationId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Get a configuration apply operation</summary>
    public Task<ApiResponse<ConfigurationApplyOperationResponse>> GetIntegrationConfigurationApplyOperationAsync(string operationId, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ConfigurationApplyOperationResponse>("getIntegrationConfigurationApplyOperation", "GET", "/v1/configuration/apply-operations/{operationId}",
            new Dictionary<string, object?> { ["operationId"] = operationId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Identify the calling workspace and API key</summary>
    public Task<ApiResponse<ConfigurationContextResponse>> GetIntegrationConfigurationContextAsync(string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ConfigurationContextResponse>("getIntegrationConfigurationContext", "GET", "/v1/configuration/context",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Read external repository synchronization status</summary>
    public Task<ApiResponse<ConfigurationExternalRepositoryResponse>> GetIntegrationConfigurationExternalRepositoryAsync(string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ConfigurationExternalRepositoryResponse>("getIntegrationConfigurationExternalRepository", "GET", "/v1/configuration/external-repository",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Read the current external import's saved-case evidence</summary>
    public Task<ApiResponse<ConfigurationImportVerificationResponse>> GetIntegrationConfigurationImportVerificationAsync(string runId, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ConfigurationImportVerificationResponse>("getIntegrationConfigurationImportVerification", "GET", "/v1/configuration/external-repository/verification/{runId}",
            new Dictionary<string, object?> { ["runId"] = runId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Read configuration verification</summary>
    public Task<ApiResponse<ConfigurationVerificationResponse>> GetIntegrationConfigurationVerificationAsync(string runId, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ConfigurationVerificationResponse>("getIntegrationConfigurationVerification", "GET", "/v1/configuration/verification-runs/{runId}",
            new Dictionary<string, object?> { ["runId"] = runId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>List workspace configuration changes</summary>
    public Task<ApiResponse<ConfigurationApplyOperationHistoryResponse>> ListIntegrationConfigurationApplyOperationsAsync(string? xRequestId = null, int? limit = null, string? cursor = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ConfigurationApplyOperationHistoryResponse>("listIntegrationConfigurationApplyOperations", "GET", "/v1/configuration/apply-operations",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["limit"] = limit, ["cursor"] = cursor },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Plan desired workspace configuration</summary>
    public Task<ApiResponse<ConfigurationPlanResponse>> PlanIntegrationConfigurationAsync(ConfigurationPlanRequest body, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ConfigurationPlanResponse>("planIntegrationConfiguration", "POST", "/v1/configuration/plan",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            RequestBody.Json(body), options, cancellationToken);

    /// <summary>Verify saved cases in an exact configuration plan</summary>
    public Task<ApiResponse<ConfigurationVerificationResponse>> VerifyIntegrationConfigurationAsync(ConfigurationVerificationRequest body, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<ConfigurationVerificationResponse>("verifyIntegrationConfiguration", "POST", "/v1/configuration/verification-runs",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            RequestBody.Json(body), options, cancellationToken);

}

public sealed class OutboundAS2Api
{
    private readonly ModernEdiClient client;
    internal OutboundAS2Api(ModernEdiClient client) { this.client = client; }

    /// <summary>Send already-generated X12 to a carbon-copy partner</summary>
    public Task<ApiResponse<SendSuccessResponse>> CarbonCopyGeneratedX12Async(RequestBody body, int partnerId, string x12Version, string functionalGroupType, int transactionGroupType, string originalMessageId, int copyToPartnerId, string? xRequestId = null, bool? test = null, string? idempotencyKey = null, string? originalTransactionKey = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<SendSuccessResponse>("carbonCopyGeneratedX12", "POST", "/v1/as2/x12/carbonCopy",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["test"] = test, ["partnerId"] = partnerId, ["x12Version"] = x12Version, ["functionalGroupType"] = functionalGroupType, ["transactionGroupType"] = transactionGroupType, ["originalMessageId"] = originalMessageId, ["originalTransactionKey"] = originalTransactionKey, ["copyToPartnerId"] = copyToPartnerId },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId, ["Idempotency-Key"] = idempotencyKey },
            body, options, cancellationToken);

    /// <summary>Transform and validate an outbound document without sending it</summary>
    public Task<ApiResponse<OutboundPreviewResponse>> PreviewOutboundX12Async(RequestBody body, int partnerId, string x12Version, string functionalGroupType, int transactionGroupType, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<OutboundPreviewResponse>("previewOutboundX12", "POST", "/v1/as2/preview",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["partnerId"] = partnerId, ["x12Version"] = x12Version, ["functionalGroupType"] = functionalGroupType, ["transactionGroupType"] = transactionGroupType },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            body, options, cancellationToken);

    /// <summary>Send a follow-up document tied to an inbound message</summary>
    public Task<ApiResponse<SendSuccessResponse>> ReplyToInboundAs2MessageAsync(RequestBody body, string originalMessageId, string? xRequestId = null, bool? test = null, string? idempotencyKey = null, int? partnerId = null, string? x12Version = null, string? functionalGroupType = null, int? transactionGroupType = null, string? originalTransactionKey = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<SendSuccessResponse>("replyToInboundAs2Message", "POST", "/v1/as2/reply",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["test"] = test, ["partnerId"] = partnerId, ["x12Version"] = x12Version, ["functionalGroupType"] = functionalGroupType, ["transactionGroupType"] = transactionGroupType, ["originalMessageId"] = originalMessageId, ["originalTransactionKey"] = originalTransactionKey },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId, ["Idempotency-Key"] = idempotencyKey },
            body, options, cancellationToken);

    /// <summary>Reply to an inbound message with already-generated X12</summary>
    public Task<ApiResponse<SendSuccessResponse>> ReplyWithGeneratedX12Async(RequestBody body, string functionalGroupType, int transactionGroupType, string originalMessageId, string? xRequestId = null, bool? test = null, string? idempotencyKey = null, int? partnerId = null, string? x12Version = null, string? originalTransactionKey = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<SendSuccessResponse>("replyWithGeneratedX12", "POST", "/v1/as2/x12/reply",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["test"] = test, ["partnerId"] = partnerId, ["x12Version"] = x12Version, ["functionalGroupType"] = functionalGroupType, ["transactionGroupType"] = transactionGroupType, ["originalMessageId"] = originalMessageId, ["originalTransactionKey"] = originalTransactionKey },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId, ["Idempotency-Key"] = idempotencyKey },
            body, options, cancellationToken);

    /// <summary>Send a carbon copy of an inbound message flow to another partner</summary>
    public Task<ApiResponse<SendSuccessResponse>> SendAs2CarbonCopyAsync(RequestBody body, int partnerId, string x12Version, string functionalGroupType, int transactionGroupType, string originalMessageId, int copyToPartnerId, string? xRequestId = null, bool? test = null, string? idempotencyKey = null, string? originalTransactionKey = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<SendSuccessResponse>("sendAs2CarbonCopy", "POST", "/v1/as2/carbonCopy",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["test"] = test, ["partnerId"] = partnerId, ["x12Version"] = x12Version, ["functionalGroupType"] = functionalGroupType, ["transactionGroupType"] = transactionGroupType, ["originalMessageId"] = originalMessageId, ["originalTransactionKey"] = originalTransactionKey, ["copyToPartnerId"] = copyToPartnerId },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId, ["Idempotency-Key"] = idempotencyKey },
            body, options, cancellationToken);

    /// <summary>Send a standalone outbound document</summary>
    public Task<ApiResponse<SendSuccessResponse>> SendAs2MessageAsync(RequestBody body, int partnerId, string x12Version, string functionalGroupType, int transactionGroupType, string? xRequestId = null, bool? test = null, string? idempotencyKey = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<SendSuccessResponse>("sendAs2Message", "POST", "/v1/as2/send",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["test"] = test, ["partnerId"] = partnerId, ["x12Version"] = x12Version, ["functionalGroupType"] = functionalGroupType, ["transactionGroupType"] = transactionGroupType },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId, ["Idempotency-Key"] = idempotencyKey },
            body, options, cancellationToken);

    /// <summary>Send an already-generated X12 document</summary>
    public Task<ApiResponse<SendSuccessResponse>> SendGeneratedX12MessageAsync(RequestBody body, int partnerId, string x12Version, string functionalGroupType, int transactionGroupType, string? xRequestId = null, bool? test = null, string? idempotencyKey = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<SendSuccessResponse>("sendGeneratedX12Message", "POST", "/v1/as2/x12/send",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["test"] = test, ["partnerId"] = partnerId, ["x12Version"] = x12Version, ["functionalGroupType"] = functionalGroupType, ["transactionGroupType"] = transactionGroupType },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId, ["Idempotency-Key"] = idempotencyKey },
            body, options, cancellationToken);

}

public sealed class AS2ConnectionsApi
{
    private readonly ModernEdiClient client;
    internal AS2ConnectionsApi(ModernEdiClient client) { this.client = client; }

    /// <summary>Get a partner AS2 connection</summary>
    public Task<ApiResponse<As2ConnectionResponse>> GetIntegrationAs2ConnectionAsync(int connectionId, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<As2ConnectionResponse>("getIntegrationAs2Connection", "GET", "/v1/as2/connections/{connectionId}",
            new Dictionary<string, object?> { ["connectionId"] = connectionId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>List partner AS2 connections</summary>
    public Task<ApiResponse<As2ConnectionListResponse>> ListIntegrationAs2ConnectionsAsync(string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<As2ConnectionListResponse>("listIntegrationAs2Connections", "GET", "/v1/as2/connections",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

}

public sealed class PartnersApi
{
    private readonly ModernEdiClient client;
    internal PartnersApi(ModernEdiClient client) { this.client = client; }

    /// <summary>Get the tenant's public AS2 profile</summary>
    public Task<ApiResponse<As2ProfileResponse>> GetIntegrationAs2ProfileAsync(string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<As2ProfileResponse>("getIntegrationAs2Profile", "GET", "/v1/as2/profile",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Get a trading partner</summary>
    public Task<ApiResponse<PartnerResponse>> GetIntegrationPartnerAsync(int partnerId, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<PartnerResponse>("getIntegrationPartner", "GET", "/v1/partners/{partnerId}",
            new Dictionary<string, object?> { ["partnerId"] = partnerId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Inspect a partner's published mapping capabilities</summary>
    public Task<ApiResponse<PartnerCapabilitiesResponse>> GetIntegrationPartnerCapabilitiesAsync(int partnerId, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<PartnerCapabilitiesResponse>("getIntegrationPartnerCapabilities", "GET", "/v1/partners/{partnerId}/capabilities",
            new Dictionary<string, object?> { ["partnerId"] = partnerId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>List configured trading partners</summary>
    public Task<ApiResponse<PartnerListResponse>> ListIntegrationPartnersAsync(string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<PartnerListResponse>("listIntegrationPartners", "GET", "/v1/partners",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

}

public sealed class MappingsApi
{
    private readonly ModernEdiClient client;
    internal MappingsApi(ModernEdiClient client) { this.client = client; }

    /// <summary>Get a published mapping</summary>
    public Task<ApiResponse<MappingResponse>> GetIntegrationMappingAsync(int mappingId, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<MappingResponse>("getIntegrationMapping", "GET", "/v1/mappings/{mappingId}",
            new Dictionary<string, object?> { ["mappingId"] = mappingId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Get a historical mapping configuration revision</summary>
    public Task<ApiResponse<MappingConfigurationRevisionResponse>> GetIntegrationMappingConfigurationRevisionAsync(int mappingId, int revisionId, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<MappingConfigurationRevisionResponse>("getIntegrationMappingConfigurationRevision", "GET", "/v1/mappings/{mappingId}/revisions/{revisionId}",
            new Dictionary<string, object?> { ["mappingId"] = mappingId, ["revisionId"] = revisionId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>List a mapping's configuration history</summary>
    public Task<ApiResponse<MappingConfigurationRevisionListResponse>> ListIntegrationMappingConfigurationRevisionsAsync(int mappingId, string? xRequestId = null, string? cursor = null, int? limit = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<MappingConfigurationRevisionListResponse>("listIntegrationMappingConfigurationRevisions", "GET", "/v1/mappings/{mappingId}/revisions",
            new Dictionary<string, object?> { ["mappingId"] = mappingId },
            new Dictionary<string, object?> { ["cursor"] = cursor, ["limit"] = limit },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>List published mappings</summary>
    public Task<ApiResponse<MappingListResponse>> ListIntegrationMappingsAsync(string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<MappingListResponse>("listIntegrationMappings", "GET", "/v1/mappings",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

}

public sealed class MappingRuntimeApi
{
    private readonly ModernEdiClient client;
    internal MappingRuntimeApi(ModernEdiClient client) { this.client = client; }

    /// <summary>Get one mapping runtime failure</summary>
    public Task<ApiResponse<MappingRuntimeFailureResponse>> GetIntegrationMappingRuntimeFailureAsync(string failureId, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<MappingRuntimeFailureResponse>("getIntegrationMappingRuntimeFailure", "GET", "/v1/integration/mapping-runtime/failures/{failureId}",
            new Dictionary<string, object?> { ["failureId"] = failureId },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Get mapping runtime health</summary>
    public Task<ApiResponse<MappingRuntimeHealthResponse>> GetIntegrationMappingRuntimeHealthAsync(string? xRequestId = null, string? environment = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<MappingRuntimeHealthResponse>("getIntegrationMappingRuntimeHealth", "GET", "/v1/integration/mapping-runtime/health",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["environment"] = environment },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>List mapping runtime failures</summary>
    public Task<ApiResponse<MappingRuntimeFailuresResponse>> ListIntegrationMappingRuntimeFailuresAsync(string? xRequestId = null, string? environment = null, int? mappingId = null, string? direction = null, bool? resolved = null, string? cursor = null, int? limit = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<MappingRuntimeFailuresResponse>("listIntegrationMappingRuntimeFailures", "GET", "/v1/integration/mapping-runtime/failures",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["environment"] = environment, ["mappingId"] = mappingId, ["direction"] = direction, ["resolved"] = resolved, ["cursor"] = cursor, ["limit"] = limit },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

}

public sealed class TransactionViewerApi
{
    private readonly ModernEdiClient client;
    internal TransactionViewerApi(ModernEdiClient client) { this.client = client; }

    /// <summary>Get transaction detail</summary>
    public Task<ApiResponse<TransactionDetailResponse>> GetIntegrationTransactionAsync(string messageId, string transactionKey, string? xRequestId = null, string? environment = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<TransactionDetailResponse>("getIntegrationTransaction", "GET", "/v1/integration/transactions/{messageId}/{transactionKey}",
            new Dictionary<string, object?> { ["messageId"] = messageId, ["transactionKey"] = transactionKey },
            new Dictionary<string, object?> { ["environment"] = environment },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Get one transaction document</summary>
    public Task<ApiResponse<TransactionDocumentResponse>> GetIntegrationTransactionDocumentAsync(string messageId, string transactionKey, string documentId, string? xRequestId = null, string? environment = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<TransactionDocumentResponse>("getIntegrationTransactionDocument", "GET", "/v1/integration/transactions/{messageId}/{transactionKey}/documents/{documentId}",
            new Dictionary<string, object?> { ["messageId"] = messageId, ["transactionKey"] = transactionKey, ["documentId"] = documentId },
            new Dictionary<string, object?> { ["environment"] = environment },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Get transaction documents</summary>
    public Task<ApiResponse<TransactionDocumentsResponse>> GetIntegrationTransactionDocumentsAsync(string messageId, string transactionKey, string? xRequestId = null, string? environment = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<TransactionDocumentsResponse>("getIntegrationTransactionDocuments", "GET", "/v1/integration/transactions/{messageId}/{transactionKey}/documents",
            new Dictionary<string, object?> { ["messageId"] = messageId, ["transactionKey"] = transactionKey },
            new Dictionary<string, object?> { ["environment"] = environment },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Get transaction events</summary>
    public Task<ApiResponse<TransactionEventsResponse>> GetIntegrationTransactionEventsAsync(string messageId, string transactionKey, string? xRequestId = null, string? environment = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<TransactionEventsResponse>("getIntegrationTransactionEvents", "GET", "/v1/integration/transactions/{messageId}/{transactionKey}/events",
            new Dictionary<string, object?> { ["messageId"] = messageId, ["transactionKey"] = transactionKey },
            new Dictionary<string, object?> { ["environment"] = environment },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Get linked reply transactions</summary>
    public Task<ApiResponse<RelatedTransactionsResponse>> GetRelatedIntegrationTransactionsAsync(string messageId, string transactionKey, string? xRequestId = null, string? environment = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<RelatedTransactionsResponse>("getRelatedIntegrationTransactions", "GET", "/v1/integration/transactions/{messageId}/{transactionKey}/related",
            new Dictionary<string, object?> { ["messageId"] = messageId, ["transactionKey"] = transactionKey },
            new Dictionary<string, object?> { ["environment"] = environment },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>List transactions</summary>
    public Task<ApiResponse<TransactionListResponse>> ListIntegrationTransactionsAsync(string? xRequestId = null, string? environment = null, bool? needsAttention = null, List<TransactionAttentionReason>? attentionReason = null, List<FilterableTransactionMappingStatus>? mappingStatus = null, List<FilterableFunctionalAcknowledgmentStatus>? functionalAckStatus = null, List<FilterableImplementationAcknowledgmentStatus>? implementationAckStatus = null, List<FilterableTransactionMdnStatus>? mdnStatus = null, string? startDate = null, string? endDate = null, string? cursor = null, int? limit = null, string? direction = null, string? partnerName = null, int? partnerId = null, string? transactionSet = null, string? businessKey = null, string? messageId = null, string? replyToMessageId = null, string? transactionControlNumber = null, string? functionalGroupControlNumber = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<TransactionListResponse>("listIntegrationTransactions", "GET", "/v1/integration/transactions",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["environment"] = environment, ["needsAttention"] = needsAttention, ["attentionReason"] = attentionReason, ["mappingStatus"] = mappingStatus, ["functionalAckStatus"] = functionalAckStatus, ["implementationAckStatus"] = implementationAckStatus, ["mdnStatus"] = mdnStatus, ["startDate"] = startDate, ["endDate"] = endDate, ["cursor"] = cursor, ["limit"] = limit, ["direction"] = direction, ["partnerName"] = partnerName, ["partnerId"] = partnerId, ["transactionSet"] = transactionSet, ["businessKey"] = businessKey, ["messageId"] = messageId, ["replyToMessageId"] = replyToMessageId, ["transactionControlNumber"] = transactionControlNumber, ["functionalGroupControlNumber"] = functionalGroupControlNumber },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Replay an inbound transaction without redelivery</summary>
    public Task<ApiResponse<TransactionReplayResponse>> ReplayIntegrationTransactionAsync(TransactionReplayRequest body, string messageId, string transactionKey, string idempotencyKey, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<TransactionReplayResponse>("replayIntegrationTransaction", "POST", "/v1/integration/transactions/{messageId}/{transactionKey}/replays",
            new Dictionary<string, object?> { ["messageId"] = messageId, ["transactionKey"] = transactionKey },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId, ["Idempotency-Key"] = idempotencyKey },
            RequestBody.Json(body), options, cancellationToken);

    /// <summary>Stop watching a transaction</summary>
    public Task<ApiResponse<TransactionWatchResponse>> UnwatchIntegrationTransactionAsync(string messageId, string transactionKey, string? xRequestId = null, string? environment = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<TransactionWatchResponse>("unwatchIntegrationTransaction", "DELETE", "/v1/integration/transactions/{messageId}/{transactionKey}/watch",
            new Dictionary<string, object?> { ["messageId"] = messageId, ["transactionKey"] = transactionKey },
            new Dictionary<string, object?> { ["environment"] = environment },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Validate the X12 retained for a transaction</summary>
    public Task<ApiResponse<TransactionX12ValidationResponse>> ValidateIntegrationTransactionX12Async(string messageId, string transactionKey, string? xRequestId = null, string? environment = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<TransactionX12ValidationResponse>("validateIntegrationTransactionX12", "GET", "/v1/integration/transactions/{messageId}/{transactionKey}/x12/validation",
            new Dictionary<string, object?> { ["messageId"] = messageId, ["transactionKey"] = transactionKey },
            new Dictionary<string, object?> { ["environment"] = environment },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Watch a transaction</summary>
    public Task<ApiResponse<TransactionWatchResponse>> WatchIntegrationTransactionAsync(string messageId, string transactionKey, string? xRequestId = null, string? environment = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<TransactionWatchResponse>("watchIntegrationTransaction", "PUT", "/v1/integration/transactions/{messageId}/{transactionKey}/watch",
            new Dictionary<string, object?> { ["messageId"] = messageId, ["transactionKey"] = transactionKey },
            new Dictionary<string, object?> { ["environment"] = environment },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

}

public sealed class AccountApi
{
    private readonly ModernEdiClient client;
    internal AccountApi(ModernEdiClient client) { this.client = client; }

    /// <summary>Get plan usage and enforcement status</summary>
    public Task<ApiResponse<UsageResponse>> GetIntegrationUsageAsync(string? xRequestId = null, int? days = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<UsageResponse>("getIntegrationUsage", "GET", "/v1/usage",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["days"] = days },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

}

public sealed class IntegrationEventsApi
{
    private readonly ModernEdiClient client;
    internal IntegrationEventsApi(ModernEdiClient client) { this.client = client; }

    /// <summary>Poll transaction-state changes</summary>
    public Task<ApiResponse<IntegrationChangeEventsResponse>> ListIntegrationChangeEventsAsync(string? xRequestId = null, string? environment = null, string? cursor = null, int? limit = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<IntegrationChangeEventsResponse>("listIntegrationChangeEvents", "GET", "/v1/integration/events",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["environment"] = environment, ["cursor"] = cursor, ["limit"] = limit },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

}

public sealed class X12ToolsApi
{
    private readonly ModernEdiClient client;
    internal X12ToolsApi(ModernEdiClient client) { this.client = client; }

    /// <summary>List transaction sets for an X12 version</summary>
    public Task<ApiResponse<X12TransactionSetsResponse>> ListX12TransactionSetsAsync(string x12Version, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<X12TransactionSetsResponse>("listX12TransactionSets", "GET", "/v1/x12/versions/{x12Version}/transaction-sets",
            new Dictionary<string, object?> { ["x12Version"] = x12Version },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>List available X12 versions</summary>
    public Task<ApiResponse<X12VersionsResponse>> ListX12VersionsAsync(string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<X12VersionsResponse>("listX12Versions", "GET", "/v1/x12/versions",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            null, options, cancellationToken);

    /// <summary>Parse and validate an X12 interchange</summary>
    public Task<ApiResponse<X12ValidationResponse>> ValidateX12Async(RequestBody body, string? xRequestId = null, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        client.SendAsync<X12ValidationResponse>("validateX12", "POST", "/v1/x12/validate",
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> {  },
            new Dictionary<string, object?> { ["X-Request-Id"] = xRequestId },
            body, options, cancellationToken);

}
