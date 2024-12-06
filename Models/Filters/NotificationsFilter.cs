using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Notifications filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class NotificationsFilter : IModelFilter<NotificationModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Notification type.
        /// </summary>
        [MessagePack.Key(2)]
        public NotificationTypes? Type { get; init; }

        /// <summary>
        /// Is disabled.
        /// </summary>
        [MessagePack.Key(3)]
        public bool? IsDisabled { get; init; }
    }
}
