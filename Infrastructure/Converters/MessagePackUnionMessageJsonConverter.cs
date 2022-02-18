using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Converter using MessagePack Union attribute to identify message types.
    /// </summary>
    /// <typeparam name="TMessage">Message type, this type must derive <see cref="IMessage"/> and must not be equal to <see cref="IMessage"/>.</typeparam>
    public class MessagePackUnionMessageJsonConverter<TMessage> : PolymorphicObjectJsonConverter<TMessage> where TMessage : IMessage
    {
        #region CONSTRUCTOR

        /// <inheritdoc/>
        public MessagePackUnionMessageJsonConverter() : base()
        {
            if (typeof(TMessage) == typeof(IMessage))
                throw new NotSupportedException($"Type of {nameof(IMessage)} not supported. Use derived types instead.");
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="payloadPropertyName">Payload property name.</param>
        /// <param name="descriminatorPropertyName">Descriminator property name.</param>
        /// <exception cref="ArgumentNullException">thrown if value specified by <paramref name="payloadPropertyName"/>is null or empty string.</exception>
        public MessagePackUnionMessageJsonConverter(string payloadPropertyName,string descriminatorPropertyName):base(descriminatorPropertyName)
        {
            if(string.IsNullOrEmpty(payloadPropertyName))
                throw new ArgumentNullException(nameof(payloadPropertyName));

            PAYLOAD_PROPERTY_NAME = payloadPropertyName;
        }

        /// <summary>
        /// Static constructor.
        /// </summary>
        static MessagePackUnionMessageJsonConverter()
        {
            //get all union attributes applied to the generic target type
            var exactTypes = targetType.GetCustomAttributes<UnionAttribute>();

            //create look up dictionaries
            unionCodeLookup = exactTypes.ToDictionary(key => key.Key, value => value.SubType);
            typeLookup = exactTypes.ToDictionary(key => key.SubType, value => value.Key);
        }

        #endregion

        #region FIELDS

        private static readonly Type targetType = typeof(TMessage);
        private static readonly Dictionary<int, Type> unionCodeLookup;
        private static readonly Dictionary<Type, int> typeLookup;
        private readonly string PAYLOAD_PROPERTY_NAME = DEFAULT_PAYLOAD_PROPERTY_NAME;
        private static readonly string DEFAULT_PAYLOAD_PROPERTY_NAME = "Message";

        #endregion      

        #region OVERRIDES

        /// <inheritdoc/>                    
        public override bool CanConvert(Type typeToConvert)
        {
            return typeLookup.ContainsKey(typeToConvert) || typeToConvert.IsAssignableFrom(targetType);
        }

        /// <inheritdoc/>
        public override TMessage? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            //read event descriminator
            var descriminator = ReadDescriminator(ref reader);

            //read to the event value property
            if (!reader.Read())
                throw new JsonException();

            //get associated type
            var type = GetUnionByInterfaceType(descriminator);

            //deserialize to associated type
            object result = JsonSerializer.Deserialize(ref reader, type);

            //read to the end of message
            reader.Read();

            return (TMessage)result;
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, TMessage value, JsonSerializerOptions options)
        {
            //start of our message
            writer.WriteStartObject();

            //get exact value type
            var valueType = value.GetType();

            //get value type code
            int typeCode = GetUnionByExactType(valueType);

            //write descriminator type
            WriteDescriminator(writer, typeCode);

            //write the message property
            writer.WritePropertyName(DEFAULT_PAYLOAD_PROPERTY_NAME);

            //serialize message
            JsonSerializer.Serialize(writer, value, valueType);

            //end of our message
            writer.WriteEndObject();
        }

        #endregion

        #region PRIVATE FUNCTIONS

        private Type GetUnionByInterfaceType(int unionCode)
        {
            //we could use try get value methods here
            return unionCodeLookup[unionCode];
        }

        private int GetUnionByExactType(Type exactType)
        {
            //we could use try get value methods here
            return typeLookup[exactType];
        }

        #endregion
    }
}
