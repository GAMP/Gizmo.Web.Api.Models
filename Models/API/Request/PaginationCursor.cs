using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using MessagePack;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
        public override PaginationCursor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            throw new NotSupportedException();

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, PaginationCursor value, JsonSerializerOptions options) =>
            writer.WriteBase64StringValue(JsonSerializer.SerializeToUtf8Bytes(value, options));
    }

    /// <summary>
    /// Binds <see cref="PaginationCursor"/> class from a base64 encoded json string.
    /// </summary>
    public sealed class CursorModelBinder : IModelBinder
    {
        /// <inheritdoc/>
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            //see if cursor provided as query parameter
            if (!bindingContext.HttpContext.Request.Query.TryGetValue("Pagination.Cursor", out var cursor))
                return Task.CompletedTask;

            //decode base64 string to a byte array
            var jsonArray = Convert.FromBase64String(cursor);

            var reader2 = new Utf8JsonReader(jsonArray);

            var pcursor = new PaginationCursor();
            while (reader2.Read())
            {
                if (reader2.TokenType == JsonTokenType.PropertyName)
                {
                    var propertyName = reader2.GetString()?.ToLower();
                    reader2.Read();
                    switch (propertyName)
                    {
                        case "id":
                            pcursor.Id = reader2.GetInt32();
                            break;
                        case "name":
                            pcursor.Name = reader2.GetString()!;
                            break;
                        case "value":
                            pcursor.Value = reader2.GetString()!;
                            break;
                        case "isforward":
                            pcursor.IsForward = reader2.GetBoolean();
                            break;
                    }
                }
            }

            bindingContext.Result = ModelBindingResult.Success(pcursor);

            return Task.CompletedTask;
        }
    }
}
