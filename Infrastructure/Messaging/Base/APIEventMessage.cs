using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Event base message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public abstract class APIEventMessage : SerializationTypeMessage, IAPIEventMessage
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public APIEventMessage() : base(ISerializationType)
        { }

        #endregion

        #region READ ONLY FILEDS

        /// <summary>
        /// Serialization type.
        /// </summary>
        public static readonly Type ISerializationType = typeof(IAPIEventMessage);

        #endregion
    }
}
