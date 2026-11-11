using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User event base message.
    /// </summary>
    public abstract class UserEventMessage : EventMessage, IUserEventMessage
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        protected UserEventMessage() : base(ISerializationType)
        { }

        #endregion

        #region READ ONLY FILEDS

        /// <summary>
        /// Serialization type.
        /// </summary>
        public static readonly Type ISerializationType = typeof(IUserEventMessage);

        #endregion
    }
}
