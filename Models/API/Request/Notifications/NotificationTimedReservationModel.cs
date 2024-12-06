using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Notification timed reservation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class NotificationTimedReservationModel : NotificationModel, INotificationModel, IModelIntIdentifier
    {
        ///<inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Minute.
        /// </summary>
        [MessagePack.Key(1)]
        public int Minute { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public NotificationType Type { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public NotificationFocusType FocusType { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public string? Message { get; init; }
    }
}
