using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Json converter for the polymorphic web api error collection.
    /// </summary>
    /// <remarks>
    /// The error base type is abstract, so the default json reader cannot build a value for it and
    /// the shared error envelope cannot be read from a json response. The concrete type is taken
    /// from the payload shape: a property name together with a message list is the grouped
    /// validation error, a property name alone is a single validation error, and anything else is
    /// a plain error message.
    /// </remarks>
    public sealed class WebApiErrorBaseJsonConverter : JsonConverter<WebApiErrorBase>
    {
        /// <inheritdoc/>
        public override WebApiErrorBase? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;

            using var document = JsonDocument.ParseValue(ref reader);
            var root = document.RootElement;

            if (root.ValueKind != JsonValueKind.Object)
                return null;

            var propertyName = GetString(root, "propertyName");
            var messages = GetStringArray(root, "messages");

            if (propertyName is not null && messages is not null)
                return new WebApiValidationErrors { PropertyName = propertyName, Messages = messages };

            var message = GetString(root, "message") ?? string.Empty;

            return propertyName is null
                ? new WebApiError(message)
                : new WebApiValidationError(propertyName, message);
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, WebApiErrorBase value, JsonSerializerOptions options)
        {
            //the concrete type carries the payload, so it is written with its own contract
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }

        /// <summary>
        /// Reads one optional string property.
        /// </summary>
        /// <param name="root">Object to read from.</param>
        /// <param name="name">Property name.</param>
        /// <returns>Property value or null when the property is absent or not a string.</returns>
        private static string? GetString(JsonElement root, string name)
        {
            if (!root.TryGetProperty(name, out var value) || value.ValueKind != JsonValueKind.String)
                return null;

            return value.GetString();
        }

        /// <summary>
        /// Reads one optional string array property.
        /// </summary>
        /// <param name="root">Object to read from.</param>
        /// <param name="name">Property name.</param>
        /// <returns>Property value or null when the property is absent or not an array of strings.</returns>
        private static string[]? GetStringArray(JsonElement root, string name)
        {
            if (!root.TryGetProperty(name, out var value) || value.ValueKind != JsonValueKind.Array)
                return null;

            var items = new List<string>();

            foreach (var item in value.EnumerateArray())
            {
                if (item.ValueKind == JsonValueKind.String && item.GetString() is { } text)
                    items.Add(text);
            }

            return items.ToArray();
        }
    }
}
