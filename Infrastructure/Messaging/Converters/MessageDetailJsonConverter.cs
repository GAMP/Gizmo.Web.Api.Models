using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    public abstract class JsonConverterBase<T> :JsonConverter<T>
    {
        #region FIELDS

        private const string DESCRIMINATOR_NAME = "TypeDiscriminator";

        #endregion

        protected T ReadDescriminator<T>(ref Utf8JsonReader reader) where T : Enum
        {
            reader.Read();
            if (reader.TokenType != JsonTokenType.PropertyName)
                throw new JsonException();

            string propertyName = reader.GetString();
            if (propertyName != DESCRIMINATOR_NAME)
                throw new JsonException();

            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
                throw new JsonException();

            return (T)(object)reader.GetInt32();
        }

        protected void WriteDescriminator<T>(Utf8JsonWriter writer, T descriminator) where T : Enum
        {
            writer.WriteNumber(DESCRIMINATOR_NAME, (int)(object)descriminator);
        }
    }

    public class MessageDetailJsonConverter : JsonConverter<IMessageDetail>
    {
   



        public override IMessageDetail Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, IMessageDetail value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
