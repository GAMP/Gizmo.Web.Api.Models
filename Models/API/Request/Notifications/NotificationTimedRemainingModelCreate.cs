namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Notification timed remaining model create.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class NotificationTimedRemainingModelCreate : INotificationModel
    {
        /// <summary>
        /// Minute.
        /// </summary>
        [MessagePack.Key(0)]
        public int Minute { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public NotificationType Type { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public NotificationFocusType FocusType { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public string? Message { get; init; }
    }
}
