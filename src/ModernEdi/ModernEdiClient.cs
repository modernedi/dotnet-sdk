using System.Globalization;
using System.Net;
using System.Text;
using System.Text.Json;

namespace ModernEdi;

public sealed record RequestOptions
{
    public IReadOnlyDictionary<string, string> Headers { get; init; } = new Dictionary<string, string>();
    public TimeSpan? Timeout { get; init; }
}

public sealed class RequestBody
{
    internal byte[] Bytes { get; }
    public string ContentType { get; }
    public RequestBody(ReadOnlySpan<byte> bytes, string contentType)
    {
        if (string.IsNullOrWhiteSpace(contentType) || contentType.Contains('\r') || contentType.Contains('\n'))
            throw new ArgumentException("A single Content-Type is required.", nameof(contentType));
        Bytes = bytes.ToArray(); ContentType = contentType;
    }
    public static RequestBody Json<T>(T value, string contentType = "application/json") =>
        new(JsonSerializer.SerializeToUtf8Bytes(value, WireJson.Options), contentType);
    public static RequestBody Text(string value, string contentType = "text/plain") => new(Encoding.UTF8.GetBytes(value), contentType);
}

public sealed record RetryOptions
{
    public int MaxAttempts { get; init; } = 3;
    public TimeSpan BaseDelay { get; init; } = TimeSpan.FromMilliseconds(250);
    public TimeSpan MaxDelay { get; init; } = TimeSpan.FromSeconds(10);
    internal void Validate()
    {
        if (MaxAttempts < 1 || MaxAttempts > 10 || BaseDelay < TimeSpan.Zero || MaxDelay < TimeSpan.Zero)
            throw new ArgumentException("Retry attempts must be 1–10 and delays non-negative.");
    }
}

public sealed class ApiResponse<T>
{
    public T? Data { get; }
    public int StatusCode { get; }
    public IReadOnlyDictionary<string, string> Headers { get; }
    public ReadOnlyMemory<byte> RawBody { get; }
    public string? RequestId => Header("X-Request-Id");
    public string? RetryAfter => Header("Retry-After");
    public string? ETag => Header("ETag");
    public string? Location => Header("Location");
    public string? ContentSha256 => Header("X-Content-SHA256");
    public bool? IdempotencyReplayed => Header("Idempotency-Replayed")?.Trim().ToLowerInvariant() switch { "true" => true, "false" => false, _ => null };
    private string? Header(string name) => Headers.TryGetValue(name, out var value) ? value : null;
    internal ApiResponse(T? data, HttpResponseMessage response, byte[] body)
    {
        Data = data; StatusCode = (int)response.StatusCode; RawBody = body;
        Headers = ReadHeaders(response);
    }
    internal static IReadOnlyDictionary<string, string> ReadHeaders(HttpResponseMessage response) => response.Headers.Concat(response.Content.Headers)
        .GroupBy(h => h.Key, StringComparer.OrdinalIgnoreCase).ToDictionary(g => g.Key, g => string.Join(",", g.SelectMany(h => h.Value)), StringComparer.OrdinalIgnoreCase);
}

public sealed class ModernEdiApiException : Exception
{
    public int StatusCode { get; }
    public string Code { get; }
    public string? RequestId { get; }
    public string? RetryAfter { get; }
    public bool Retryable { get; }
    public JsonElement? Details { get; }
    public ReadOnlyMemory<byte> RawBody { get; }
    public IReadOnlyDictionary<string, string> Headers { get; }
    internal ModernEdiApiException(HttpResponseMessage response, byte[] body, JsonElement? error)
        : base(String(error, "message") ?? $"ModernEDI returned HTTP {(int)response.StatusCode}")
    {
        StatusCode = (int)response.StatusCode; RawBody = body; Headers = ApiResponse<object>.ReadHeaders(response);
        Code = String(error, "code") ?? "http_error";
        RequestId = String(error, "requestId") ?? Headers.GetValueOrDefault("X-Request-Id");
        RetryAfter = Headers.GetValueOrDefault("Retry-After");
        Retryable = Property(error, "retryable")?.ValueKind == JsonValueKind.True;
        Details = Property(error, "details")?.Clone();
    }
    private static JsonElement? Property(JsonElement? json, string name) => json?.ValueKind == JsonValueKind.Object && json.Value.TryGetProperty(name, out var value) ? value : null;
    private static string? String(JsonElement? json, string name) => Property(json, name) is { ValueKind: JsonValueKind.String } value ? value.GetString() : null;
    internal static ModernEdiApiException Create(HttpResponseMessage response, byte[] body)
    {
        try { using var json = JsonDocument.Parse(body); return new(response, body, Property(json.RootElement, "error")); }
        catch (JsonException) { return new(response, body, null); }
    }
}

/// <summary>A reusable server-side client. Keep it alive for connection pooling; dispose owned clients.</summary>
public sealed partial class ModernEdiClient : IDisposable
{
    private readonly HttpClient http;
    private readonly bool ownsHttp;
    private readonly string baseUrl;
    private readonly string authName;
    private readonly string authValue;
    private readonly TimeSpan timeout;
    private readonly RetryOptions retry;

    public ModernEdiClient(string? apiKey = null, string? bearerToken = null, string baseUrl = "https://api.modernedi.com",
        HttpClient? httpClient = null, RetryOptions? retry = null, TimeSpan? timeout = null)
    {
        if ((apiKey is null) == (bearerToken is null)) throw new ArgumentException("Provide exactly one of apiKey or bearerToken.");
        var credential = apiKey ?? bearerToken!;
        if (string.IsNullOrWhiteSpace(credential) || credential.Contains('\r') || credential.Contains('\n')) throw new ArgumentException("Credential must be a non-empty single-line string.");
        if (!Uri.TryCreate(baseUrl, UriKind.Absolute, out var uri) || !string.IsNullOrEmpty(uri.UserInfo) ||
            !string.IsNullOrEmpty(uri.Query) || !string.IsNullOrEmpty(uri.Fragment) ||
            (uri.Scheme != "https" && !(uri.Scheme == "http" && uri.IsLoopback)))
            throw new ArgumentException("baseUrl must use HTTPS (HTTP only for loopback testing), without credentials, query, or fragment.");
        this.baseUrl = baseUrl.TrimEnd('/');
        authName = apiKey is not null ? "X-API-Key" : "Authorization";
        authValue = apiKey is not null ? credential : $"Bearer {credential}";
        this.retry = retry ?? new() { MaxAttempts = 1 }; this.retry.Validate();
        this.timeout = timeout ?? TimeSpan.FromSeconds(30);
        if (this.timeout <= TimeSpan.Zero) throw new ArgumentOutOfRangeException(nameof(timeout));
        if (httpClient is not null && (httpClient.DefaultRequestHeaders.Contains("Authorization") || httpClient.DefaultRequestHeaders.Contains("X-API-Key")))
            throw new ArgumentException("Pass credentials to ModernEdiClient, not HTTP client default headers.");
        ownsHttp = httpClient is null;
        http = httpClient ?? new HttpClient(new SocketsHttpHandler { AllowAutoRedirect = false }) { Timeout = Timeout.InfiniteTimeSpan };
    }

    internal async Task<ApiResponse<T>> SendAsync<T>(string operation, string method, string path,
        Dictionary<string, object?> pathParams, Dictionary<string, object?> query, Dictionary<string, object?> headers,
        RequestBody? body, RequestOptions? options, CancellationToken cancellationToken)
    {
        options ??= new();
        var requestHeaders = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { ["Accept"] = "application/json" };
        foreach (var pair in options.Headers) SetHeader(requestHeaders, pair.Key, pair.Value);
        foreach (var pair in headers) if (pair.Value is not null) SetHeader(requestHeaders, pair.Key, Scalar(pair.Value));
        if (body is not null && requestHeaders.TryGetValue("Content-Type", out var contentType) && contentType != body.ContentType)
            throw new ArgumentException("Content-Type must match RequestBody.ContentType.");
        var safe = (method is "GET" or "HEAD" or "OPTIONS") && path != "/v1/mapped-outputs" ||
            method == "POST" && path == "/v1/configuration/plan" ||
            (method is "PUT" or "DELETE") && path == "/v1/integration/transactions/{messageId}/{transactionKey}/watch" ||
            headers.Keys.Any(name => name.Equals("Idempotency-Key", StringComparison.OrdinalIgnoreCase)) &&
            requestHeaders.TryGetValue("Idempotency-Key", out var key) && !string.IsNullOrWhiteSpace(key);
        foreach (var pair in pathParams)
        {
            var value = pair.Value is null ? "" : Scalar(pair.Value);
            if (value is "" or "." or "..") throw new ArgumentException($"Invalid path parameter: {pair.Key}");
            path = path.Replace("{" + pair.Key + "}", Uri.EscapeDataString(value), StringComparison.Ordinal);
        }
        var queryParts = query.Where(p => p.Value is not null).SelectMany(p =>
            (p.Value is System.Collections.IEnumerable values && p.Value is not string ? values.Cast<object>() : [p.Value!])
                .Select(value => Uri.EscapeDataString(p.Key) + "=" + Uri.EscapeDataString(Scalar(value))));
        var queryString = string.Join("&", queryParts);
        var url = baseUrl + path + (queryString.Length > 0 ? "?" + queryString : "");
        var requestTimeout = options.Timeout ?? timeout;
        if (requestTimeout <= TimeSpan.Zero) throw new ArgumentOutOfRangeException(nameof(options), "Timeout must be positive.");
        using var deadline = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        deadline.CancelAfter(requestTimeout);
        for (var attempt = 1; attempt <= retry.MaxAttempts; attempt++)
        {
            using var request = new HttpRequestMessage(new HttpMethod(method), url);
            if (body is not null)
            {
                request.Content = new ByteArrayContent(body.Bytes);
                request.Content.Headers.TryAddWithoutValidation("Content-Type", body.ContentType);
            }
            foreach (var pair in requestHeaders)
                if (!pair.Key.Equals("Content-Type", StringComparison.OrdinalIgnoreCase)) request.Headers.Add(pair.Key, pair.Value);
            request.Headers.Add(authName, authValue);
            HttpResponseMessage response;
            try { response = await http.SendAsync(request, deadline.Token).ConfigureAwait(false); }
            catch (HttpRequestException) when (safe && attempt < retry.MaxAttempts)
            {
                await Task.Delay(Backoff(attempt), deadline.Token).ConfigureAwait(false); continue;
            }
            using (response)
            {
                if (safe && attempt < retry.MaxAttempts && Delay(response, attempt) is { } delay)
                { await Task.Delay(delay, deadline.Token).ConfigureAwait(false); continue; }
                var bytes = await response.Content.ReadAsByteArrayAsync(deadline.Token).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode && response.StatusCode != HttpStatusCode.NotModified)
                    throw ModernEdiApiException.Create(response, bytes);
                T? data = default;
                if (bytes.Length > 0 && response.StatusCode is not HttpStatusCode.NoContent and not HttpStatusCode.NotModified)
                    data = typeof(T) == typeof(byte[]) ? (T)(object)bytes : JsonSerializer.Deserialize<T>(bytes, WireJson.Options);
                return new(data, response, bytes);
            }
        }
        throw new InvalidOperationException("Retry loop exhausted.");
    }

    private TimeSpan Backoff(int attempt) => TimeSpan.FromMilliseconds(Math.Min(retry.BaseDelay.TotalMilliseconds * Math.Pow(2, attempt - 1), retry.MaxDelay.TotalMilliseconds));
    private TimeSpan? Delay(HttpResponseMessage response, int attempt)
    {
        if ((int)response.StatusCode is not (429 or 502 or 503 or 504)) return null;
        var delay = response.Headers.RetryAfter?.Delta ?? (response.Headers.RetryAfter?.Date is { } date
            ? date - DateTimeOffset.UtcNow : Backoff(attempt));
        if (delay < TimeSpan.Zero) delay = TimeSpan.Zero;
        return delay > retry.MaxDelay ? null : delay;
    }
    private static string Scalar(object value) => value is bool boolean ? (boolean ? "true" : "false") : value is Enum
        ? JsonSerializer.SerializeToElement(value, WireJson.Options).GetString()! : Convert.ToString(value, CultureInfo.InvariantCulture)!;
    private static void SetHeader(Dictionary<string, string> headers, string name, string value)
    {
        if (name.ToLowerInvariant() is "authorization" or "x-api-key" or "host" or "content-length") throw new ArgumentException($"{name} cannot override authentication or routing.");
        if (value.Contains('\r') || value.Contains('\n')) throw new ArgumentException("Header values cannot contain newlines.");
        headers[name] = value;
    }
    public void Dispose() { if (ownsHttp) http.Dispose(); }
}
