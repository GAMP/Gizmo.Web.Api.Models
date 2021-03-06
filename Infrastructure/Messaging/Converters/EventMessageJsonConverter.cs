﻿using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace Gizmo.Web.Api.Messaging
{
    /// <inheritdoc/>
    /// <typeparam name="TMessage">Message type, this type must derive <see cref="IEventMessage"/> and must not be equal to <see cref="IEventMessage"/>.</typeparam>
    public class EventMessageJsonConverter<TMessage> : PolymorphicObjectJsonConverter<TMessage> where TMessage : IEventMessage
    {
        #region CONSTRUCTOR

        /// <inheritdoc/>
        public EventMessageJsonConverter() : base()
        {
            if (typeof(TMessage) == typeof(IEventMessage))
                throw new NotSupportedException($"Type of {nameof(IEventMessage)} not supported. Use derived types instead.");
        }

        /// <summary>
        /// Static constructor.
        /// </summary>
        static EventMessageJsonConverter()
        {
            var exactTypes = targetType.GetCustomAttributes<UnionAttribute>();
            unionCodeLookup = exactTypes.ToDictionary(key => key.Key, value => value.SubType);
            typeLookup = exactTypes.ToDictionary(key => key.SubType, value => value.Key);
        }

        #endregion

        #region FIELDS

        private static readonly Type targetType = typeof(TMessage);
        private static readonly Dictionary<int, Type> unionCodeLookup;
        private static readonly Dictionary<Type, int> typeLookup;
        private static readonly string PAYLOAD_PROPERTY_NAME = "Event";

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
            object result = JsonSerializer.Deserialize(ref reader,type);       

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
            writer.WritePropertyName(PAYLOAD_PROPERTY_NAME);

            //serialize message
            JsonSerializer.Serialize(writer, value, valueType);

            //end of our message
            writer.WriteEndObject();
        }

        #endregion

        #region PRIVATE FUNCTIONS
        
        private Type GetUnionByInterfaceType(int unionCode)
        {
            return unionCodeLookup[unionCode];
        }

        private int GetUnionByExactType(Type exactType)
        {
            return typeLookup[exactType];
        } 

        #endregion
    }
}
