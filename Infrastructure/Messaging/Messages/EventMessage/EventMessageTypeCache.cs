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

        /// <summary>
        /// Order event message.
        /// </summary>
        public static readonly Type IOrderEventMessage = typeof(IOrderEventMessage);

        /// <summary>
        /// Product event message.
        /// </summary>
        public static readonly Type IProductEventMessage = typeof(IProductEventMessage);

        /// <summary>
        /// Host event message.
        /// </summary>
        public static readonly Type IHostEventMessage = typeof(IHostEventMessage);

        /// <summary>
        /// Reservation event message.
        /// </summary>
        public static readonly Type IReservationEventMessage = typeof(IReservationEventMessage);

        #endregion
    }
}
