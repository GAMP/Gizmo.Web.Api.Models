using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Entity event message type cache.
    /// </summary>
    public static class EventMessageTypeCache
    {
        #region READ ONLY FIELDS
        
        /// <summary>
        /// Entity event.
        /// </summary>
        public static readonly Type IEntityEventMessage = typeof(IEntityEventMessage);

        /// <summary>
        /// User event message.
        /// </summary>
        public static readonly Type IUserEventMessage = typeof(IUserEventMessage);

        #endregion
    }
}
