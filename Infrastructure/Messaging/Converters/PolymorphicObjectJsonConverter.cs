using System.Text.Json;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Polymorphic object json converter.
    /// </summary>
    /// <typeparam name="TObjectType">Object type.</typeparam>
    public abstract class PolymorphicObjectJsonConverter<TObjectType> : JsonConverter<TObjectType>
    {
        #region FIELDS

        private const string DESCRIMINATOR_NAME = "Type";

        #endregion

        #region HELPERS

        /// <summary>
        /// Reads object descriminator.
        /// </summary>
        /// <param name="reader">Json reader.</param>
        /// <returns>Object desciminator.</returns>
        protected virtual int ReadDescriminator(ref Utf8JsonReader reader)
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

            return reader.GetInt32();
        }

        /// <summary>
        /// Writes descriminator.
        /// </summary>
        /// <param name="writer">Json writer.</param>
        /// <param name="descriminator">Desciminator.</param>
        protected virtual void WriteDescriminator(Utf8JsonWriter writer, int descriminator)
        {
            writer.WriteNumber(DESCRIMINATOR_NAME, descriminator);
        }

        #endregion
    }
}
