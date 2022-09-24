using MessagePack;
using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Event base message.
    /// </summary>
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
