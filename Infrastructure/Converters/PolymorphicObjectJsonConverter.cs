using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api
{
    /// <summary>
    /// Polymorphic object json converter.
    /// </summary>
    /// <typeparam name="T">The type of object or value handled by the converter.</typeparam>
    public abstract class PolymorphicObjectJsonConverter<T> : JsonConverter<T>
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Default constructor.
        /// </summary>
        public PolymorphicObjectJsonConverter()
        { }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="discriminatorName">Custom discriminator name.</param>
        /// <exception cref="ArgumentNullException">thrown if value specified by <paramref name="discriminatorName"/>is null or empty string.</exception>
        public PolymorphicObjectJsonConverter(string discriminatorName)
        {
            if (string.IsNullOrEmpty(discriminatorName))
                throw new ArgumentNullException(nameof(discriminatorName));

            DISCRIMINATOR_NAME = discriminatorName;
        } 

        #endregion

        #region FIELDS

        private readonly string DISCRIMINATOR_NAME = DEFAULT_DISCRIMINATOR_NAME;
        private const string DEFAULT_DISCRIMINATOR_NAME = "MessageType";

        #endregion

        #region HELPERS

        /// <summary>
        /// Reads object discriminator.
        /// </summary>
        /// <param name="reader">Json reader.</param>
        /// <returns>Object discriminator.</returns>
        protected virtual int ReadDiscriminator(ref Utf8JsonReader reader)
        {
            reader.Read();
            if (reader.TokenType != JsonTokenType.PropertyName)
                throw new JsonException();

            string? propertyName = reader.GetString();
            if (propertyName == null || string.Compare(propertyName , DISCRIMINATOR_NAME, StringComparison.OrdinalIgnoreCase) != 0)
                throw new JsonException();

            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
                throw new JsonException();

            return reader.GetInt32();
        }

        /// <summary>
        /// Writes discriminator.
        /// </summary>
        /// <param name="writer">Json writer.</param>
        /// <param name="discriminator">Discriminator.</param>
        protected virtual void WriteDiscriminator(Utf8JsonWriter writer, int discriminator)
        {
            writer.WriteNumber(DISCRIMINATOR_NAME, discriminator);
        }

        #endregion
    }
}
