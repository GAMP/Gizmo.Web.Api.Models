using MessagePack;
using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Control message.
    /// </summary>
    [MessagePackObject()]
    public abstract class APIControlMessage : SerializationTypeMessage , IAPIControlMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public APIControlMessage() : base(ISerializationType)
        { }
        #endregion

        #region READ ONLY FILEDS

        /// <summary>
        /// Serialization type.
        /// </summary>
        public static readonly Type ISerializationType = typeof(IAPIControlMessage);

        #endregion
    }
}
