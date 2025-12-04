using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Alert notification creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SystemAlertNotificationCreateModel : IWebApiModel
    {
        /// <summary>
        /// Alert type.
        /// </summary>
        [MessagePack.Key(0)]
        public Gizmo.UI.AlertTypes Type { get; set; }

        /// <summary>
        /// Notification title.
        /// </summary>
        [Required()]
        [MessagePack.Key(1)]
        public string Title { get; init; } = null!;

        /// <summary>
        /// Notification message.
        /// </summary>
        [Required()]
        [MessagePack.Key(2)]
        public string Message { get; init; } = null!;
    }
}
