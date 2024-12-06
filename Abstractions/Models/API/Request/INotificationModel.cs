namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Notification model interface.
    /// </summary>
    public interface INotificationModel : IWebApiModel
    {
        /// <summary>
        /// Notification type.
        /// </summary>
        public NotificationType Type { get; init; }

        /// <summary>
        /// Focus type.
        /// </summary>
        public NotificationFocusType FocusType { get; init; }

        /// <summary>
        /// Message.
        /// </summary>
        public string? Message { get; init; }
    }
}
