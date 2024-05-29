using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace Gizmo.Web.Api
{
    /// <summary>
    /// Polymorphic json converter using MessagePack Union attribute to identify message types.
    /// </summary>
    /// <typeparam name="T"><inheritdoc/></typeparam>
    public class MessagePackUnionMessageJsonConverter<T> : PolymorphicObjectJsonConverter<T> 
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="payloadPropertyName">Payload property name.</param>
        /// <param name="discriminatorPropertyName">Discriminator property name.</param>
        /// <exception cref="ArgumentNullException">thrown if value specified by <paramref name="payloadPropertyName"/>is null or empty string.</exception>
        public MessagePackUnionMessageJsonConverter(string discriminatorPropertyName,string payloadPropertyName):base(discriminatorPropertyName)
        {
            if(string.IsNullOrEmpty(payloadPropertyName))
                throw new ArgumentNullException(nameof(payloadPropertyName));

            _payloadPropertyName = payloadPropertyName;
        }

        /// <summary>
        /// Static constructor.
        /// </summary>
        static MessagePackUnionMessageJsonConverter()
        {
            //get all union attributes applied to the generic target type
            var exactTypes = TargetType.GetCustomAttributes<UnionAttribute>();

            //create look up dictionaries
            UnionCodeLookup = exactTypes.ToDictionary(key => key.Key, value => value.SubType);
            TypeLookup = exactTypes.ToDictionary(key => key.SubType, value => value.Key);
        }

        #endregion

        #region FIELDS

        private static readonly Type TargetType = typeof(T);
        private static readonly Dictionary<int, Type> UnionCodeLookup;
        private static readonly Dictionary<Type, int> TypeLookup;
        private readonly string _payloadPropertyName = DEFAULT_PAYLOAD_PROPERTY_NAME;
        private static readonly string DEFAULT_PAYLOAD_PROPERTY_NAME = "Message";
        private static readonly System.Text.Json.JsonSerializerOptions DefaultJsonOptions = new JsonSerializerOptions() {   PropertyNameCaseInsensitive = true };

        #endregion      

        #region OVERRIDES

        /// <inheritdoc/>                    
        public override bool CanConvert(Type typeToConvert)
        {
            return TypeLookup.ContainsKey(typeToConvert) || TargetType.IsAssignableFrom(typeToConvert);
        }

        /// <inheritdoc/>
        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            //read event discriminator
            var discriminator = ReadDiscriminator(ref reader);

            //read to the event value property
            if (!reader.Read())
                throw new JsonException();

            //get associated type
            var type = GetUnionByInterfaceType(discriminator);

            if (type == null)
                throw new ArgumentException("Invalid type.");

            //deserialize to associated type
            var result = JsonSerializer.Deserialize(ref reader, type, DefaultJsonOptions);

            if (result == null)
                return default;

            //read to the end of message
            reader.Read();

            return (T)result;
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            //start of our message
            writer.WriteStartObject();

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            //get exact value type
            var valueType = value.GetType();

            //get value type code
            int typeCode = GetUnionByExactType(valueType);

            //write discriminator type
            WriteDiscriminator(writer, typeCode);

            //write the message property
            writer.WritePropertyName(_payloadPropertyName);

            //serialize message
            JsonSerializer.Serialize(writer, value, valueType, DefaultJsonOptions);

            //end of our message
            writer.WriteEndObject();
        }

        #endregion

        #region PRIVATE FUNCTIONS

        private Type GetUnionByInterfaceType(int unionCode)
        {
            //we could use try get value methods here
            return UnionCodeLookup[unionCode];
        }

        private int GetUnionByExactType(Type exactType)
        {
            //we could use try get value methods here
            return TypeLookup[exactType];
        }

        #endregion
    }
}
