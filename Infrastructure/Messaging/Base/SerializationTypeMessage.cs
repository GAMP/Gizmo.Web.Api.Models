using MessagePack;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Serialization type message.
    /// </summary>
    public abstract class SerializationTypeMessage : MessageBase, ISerializationType
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public SerializationTypeMessage(Type serializationType) : base()
        {
            SerializationType = serializationType;
        } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets serialization type.
        /// </summary>
        [JsonIgnore()]
        [IgnoreDataMember()]
        [IgnoreMember()]
        public Type SerializationType { get; protected set; } 

        #endregion
    }
}
