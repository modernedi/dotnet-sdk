using System.Text.Json;
using System.Text.Json.Serialization;
using System.Reflection;
using System.Runtime.Serialization;

namespace ModernEdi;

public sealed class WireEnumConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type type) => type.IsEnum;
    public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options) =>
        (JsonConverter)Activator.CreateInstance(typeof(WireEnumConverter<>).MakeGenericType(type))!;
    private sealed class WireEnumConverter<T> : JsonConverter<T> where T : struct, Enum
    {
        private static readonly Dictionary<T, string> Names = Enum.GetValues<T>().ToDictionary(value => value,
            value => typeof(T).GetField(value.ToString())!.GetCustomAttribute<EnumMemberAttribute>()?.Value ?? value.ToString());
        private static readonly Dictionary<string, T> Values = Names.ToDictionary(pair => pair.Value, pair => pair.Key, StringComparer.Ordinal);
        public override T Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options) =>
            reader.TokenType == JsonTokenType.String && Values.TryGetValue(reader.GetString()!, out var value) ? value : throw new JsonException($"Unknown {typeof(T).Name} value.");
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            if (!Names.TryGetValue(value, out var name)) throw new JsonException($"Unknown {typeof(T).Name} value.");
            writer.WriteStringValue(name);
        }
    }
}

/// <summary>Distinguishes an omitted field from an explicitly supplied null or default value.</summary>
[JsonConverter(typeof(OptionalConverterFactory))]
public readonly struct Optional<T>
{
    public bool IsSet { get; }
    public T? Value { get; }
    public Optional(T? value) { IsSet = true; Value = value; }
    public static implicit operator Optional<T>(T? value) => new(value);
}

public sealed class OptionalConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type type) => type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Optional<>);
    public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options) =>
        (JsonConverter)Activator.CreateInstance(typeof(OptionalConverter<>).MakeGenericType(type.GetGenericArguments()))!;

    private sealed class OptionalConverter<T> : JsonConverter<Optional<T>>
    {
        public override bool HandleNull => true;
        public override Optional<T> Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options) =>
            new(JsonSerializer.Deserialize<T>(ref reader, options));
        public override void Write(Utf8JsonWriter writer, Optional<T> value, JsonSerializerOptions options) =>
            JsonSerializer.Serialize(writer, value.Value, options);
    }
}

/// <summary>
/// A lossless JSON union. Use As&lt;T&gt; to read a documented variant; construct a new union
/// from that variant after editing. No timestamps, unknown fields, or JSON numbers are coerced.
/// </summary>
public abstract class JsonValue
{
    public JsonElement Value { get; }
    protected JsonValue(JsonElement value) { Value = value.Clone(); }
    protected JsonValue(object value) { Value = JsonSerializer.SerializeToElement(value, WireJson.Options); }
    public T As<T>() => Value.Deserialize<T>(WireJson.Options) ?? throw new JsonException("Expected a non-null union variant.");
    public override string ToString() => Value.GetRawText();
}

public sealed class JsonValueConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type type) => typeof(JsonValue).IsAssignableFrom(type);
    public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options) =>
        (JsonConverter)Activator.CreateInstance(typeof(JsonValueConverter<>).MakeGenericType(type))!;

    private sealed class JsonValueConverter<T> : JsonConverter<T> where T : JsonValue
    {
        public override T Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            return (T)Activator.CreateInstance(type, document.RootElement)!;
        }
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) => value.Value.WriteTo(writer);
    }
}

public static class WireJson
{
    public static JsonSerializerOptions Options { get; } = new()
    {
        PropertyNameCaseInsensitive = false,
        Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };
    public static T Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json, Options)
        ?? throw new JsonException("Expected a non-null response.");
    public static string Serialize<T>(T value) => JsonSerializer.Serialize(value, Options);
}
