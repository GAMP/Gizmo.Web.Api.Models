using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using MessagePack;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Pagination cursor for the data scrolling.
    /// </summary>
    [Serializable, MessagePackObject]
    [ModelBinder(BinderType = typeof(CursorModelBinder))]
    public sealed class PaginationCursor
    {
        #region PROPERTIES

        /// <summary>
        /// Integer identifier of the record.
        /// </summary>
        [Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// Sorting field name (column name) of the record.
        /// </summary>
        [Key(1)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Value of the sorting field.
        /// It's set from the cursor data of the previous request.
        /// </summary>
        [Key(2)]
        public string Value { get; set; } = null!;

        /// <summary>
        /// Direction of the scrolling by sorting field.
        /// If true - to the next chunk of the data.
        /// If false - to the previous chunk of the data.
        /// </summary>
        [Key(3)]
        public bool IsForward { get; set; } = true;

        #endregion
    }

    /// <summary>
    /// Converts pagination cursor to base64 encoded json string.
    /// </summary>
    public sealed class CursorBase64Converter : JsonConverter<PaginationCursor>
    {
        /// <inheritdoc/>
        public override PaginationCursor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            //get decoded json bytes
            var bytes = reader.GetBytesFromBase64();

            //create new json reader
            var jsonReader = new Utf8JsonReader(bytes);

            //parse the cursor
            var pcursor = new PaginationCursor();

            while (jsonReader.Read())
            {
                if (jsonReader.TokenType == JsonTokenType.PropertyName)
                {
                    var propertyName = jsonReader.GetString()?.ToLower();
                    jsonReader.Read();
                    switch (propertyName)
                    {
                        case "id":
                            pcursor.Id = jsonReader.GetInt32();
                            break;
                        case "name":
                            pcursor.Name = jsonReader.GetString()!;
                            break;
                        case "value":
                            pcursor.Value = jsonReader.GetString()!;
                            break;
                        case "isforward":
                            pcursor.IsForward = jsonReader.GetBoolean();
                            break;
                    }
                }
            }
            return pcursor;
        }
        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, PaginationCursor value, JsonSerializerOptions options) =>
            writer.WriteBase64StringValue(JsonSerializer.SerializeToUtf8Bytes(value, options));
    }

    /// <summary>
    /// Binds <see cref="PaginationCursor"/> class from a base64 encoded json string.
    /// </summary>
    public sealed class CursorModelBinder : IModelBinder
    {
        private static readonly CursorBase64Converter Converter = new();
        /// <inheritdoc/>
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            //see if cursor provided as query parameter
            if (!bindingContext.HttpContext.Request.Query.TryGetValue("Pagination.Cursor", out var cursor))
                return Task.CompletedTask;

            var e = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(cursor));
            var model = Converter.Read(ref e, typeof(PaginationCursor), new JsonSerializerOptions());

            bindingContext.Result = ModelBindingResult.Success(model);

            return Task.CompletedTask;
        }
    }
}
