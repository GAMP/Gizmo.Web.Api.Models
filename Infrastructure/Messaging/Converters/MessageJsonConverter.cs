using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <inheritdoc/>
    public class MessageJsonConverter : JsonConverter<MessageBase>
    {
        #region CONSTRUCTOR
        /// <inheritdoc/>
        public MessageJsonConverter() : base()
        {
        }
        #endregion

        #region FIELDS

        private static readonly Dictionary<MessageTypeDiscriminator, Type> TypeMap = new Dictionary<MessageTypeDiscriminator, Type>()
        {
            { MessageTypeDiscriminator.Message, typeof(MessageBase) },
            { MessageTypeDiscriminator.CommandMessage, typeof(CommandMessage) },
            { MessageTypeDiscriminator.DetailMessage, typeof(DetailedMessage) },
        };
        const string DESCRIMINATOR_NAME = "TypeDiscriminator";

        #endregion

        /// <inheritdoc/>
        public override bool CanConvert(Type typeToConvert)
        {
            return TypeMap.ContainsValue(typeToConvert);
        }

        /// <inheritdoc/>
        public override MessageBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            var messageType = ReadDescriminator<MessageTypeDiscriminator>(ref reader);

            MessageBase message = messageType switch
            {
                MessageTypeDiscriminator.DetailMessage => new DetailedMessage(),
                MessageTypeDiscriminator.CommandMessage => new CommandMessage(),
                MessageTypeDiscriminator.Message => throw new NotImplementedException(),
                _ => throw new JsonException()
            };

            reader.Read();
            if (reader.TokenType != JsonTokenType.PropertyName)
                throw new JsonException();

            reader.Read();
            message.Version = reader.GetInt32();

            switch (messageType)
            {
                case MessageTypeDiscriminator.CommandMessage:
                    ReadMessage(ref reader, message as CommandMessage);
                    break;
                case MessageTypeDiscriminator.DetailMessage:
                    ReadMessage(ref reader, message as DetailedMessage);
                    break;
                case MessageTypeDiscriminator.Message:
                    break;
            }

            return message;
        }

        private void ReadMessage(ref Utf8JsonReader reader, DetailedMessage detailedMessage)
        {
            reader.Read();
            if (reader.TokenType != JsonTokenType.PropertyName)
                return;

            detailedMessage.Detail = ReadDetail(ref reader);          

        }

        private void ReadMessage(ref Utf8JsonReader reader, CommandMessage commandMessage)
        {

        }

        private IMessageDetail ReadDetail(ref Utf8JsonReader reader)
        {
            reader.Read();
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            IMessageDetail detail = null;
            var detailType = ReadDescriminator<MessageDetailTypeDiscriminator>(ref reader);
            switch (detailType)
            {
                case MessageDetailTypeDiscriminator.BatchDetail:
                    var messages = new List<IMessageDetail>();
                    detail = new BatchMessageDetail() { Messages = messages };

                    //next property should be messages
                    reader.Read();

                    //we should had messages property name here
                    if (reader.TokenType != JsonTokenType.PropertyName)
                        break;                 

                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndArray)
                            break;

                        var detail2 = ReadDetail(ref reader);
                        messages.Add(detail2);
                    }

                    break;
                case MessageDetailTypeDiscriminator.EntityEventDetail:

                    reader.Read();
                    reader.Read();
                    int entityId = reader.GetInt32();
                    reader.Read();
                    reader.Read();
                    string entityType = reader.GetString();
                    reader.Read();
                    reader.Read();
                    int eventType = reader.GetInt32();

                    detail = new EntityMessageDetail() { EntityId = entityId, EntityType = entityType, EventType = eventType };

                    break;
            }

            return detail;
        }

   


        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, MessageBase value, JsonSerializerOptions options)
        {
            //start of our message
            writer.WriteStartObject();

            //get desciminator type
            MessageTypeDiscriminator messageTypeDiscriminator = MessageTypeDiscriminator.Message;

            if (value is DetailedMessage)
                messageTypeDiscriminator = MessageTypeDiscriminator.DetailMessage;
            else if (value is CommandMessage)
                messageTypeDiscriminator = MessageTypeDiscriminator.CommandMessage;

            //write descriminator type
            WriteDescriminator(writer, messageTypeDiscriminator);

            //write base message properties
            writer.WriteNumber(nameof(MessageBase.Version), value.Version);

            //write based on message type
            switch (messageTypeDiscriminator)
            {
                case MessageTypeDiscriminator.DetailMessage:
                    WriteMessage(writer, value as DetailedMessage);
                    break;
                case MessageTypeDiscriminator.CommandMessage:
                    WriteMessage(writer, value as CommandMessage);
                    break;
            }

            //end of our message
            writer.WriteEndObject();
        }

        private void WriteMessage(Utf8JsonWriter writer, DetailedMessage detailedMessage)
        {
            if (detailedMessage == null)
                throw new JsonException();

            //write any message properties

            var detail = detailedMessage.Detail;

            //write message detail if its present
            if (detail != null)
            {
                writer.WriteStartObject(nameof(DetailedMessage.Detail));
                WriteMessageDetail(writer, detail);
                writer.WriteEndObject();
            }
        }

        private void WriteMessage(Utf8JsonWriter writer, CommandMessage commandMessage)
        {
            if (commandMessage == null)
                throw new JsonException();

            //write command message
        }

        private void WriteMessageDetail(Utf8JsonWriter writer, IMessageDetail messageDetail)
        {
            if (messageDetail == null)
                throw new JsonException();

            switch (messageDetail)
            {
                case EntityMessageDetail entity:
                    WriteDescriminator(writer, MessageDetailTypeDiscriminator.EntityEventDetail);
                    writer.WriteNumber(nameof(entity.EntityId), entity.EntityId);
                    writer.WriteString(nameof(entity.EntityType), entity.EntityType);
                    writer.WriteNumber(nameof(entity.EventType), entity.EventType);
                    break;
                case BatchMessageDetail batch:
                    WriteDescriminator(writer, MessageDetailTypeDiscriminator.BatchDetail);
                    WriteDetailArray(writer, batch.Messages);
                    break;
            }
        }

        private void WriteDetailArray(Utf8JsonWriter writer, IEnumerable<IMessageDetail> messageDetails)
        {
            messageDetails ??= Enumerable.Empty<IMessageDetail>();

            writer.WriteStartArray(nameof(BatchMessageDetail.Messages));
            foreach (var detail in messageDetails)
            {
                writer.WriteStartObject();
                WriteMessageDetail(writer, detail);
                writer.WriteEndObject();
            }
            writer.WriteEndArray();
        }

        #region HELPERS

        private T ReadDescriminator<T>(ref Utf8JsonReader reader) where T : Enum
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

        private void WriteDescriminator<T>(Utf8JsonWriter writer, T descriminator) where T : Enum
        {
            writer.WriteNumber(DESCRIMINATOR_NAME, (int)(object)descriminator);
        }

        #endregion
    }
}
