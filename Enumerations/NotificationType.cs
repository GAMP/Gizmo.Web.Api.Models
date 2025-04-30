using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Notification type.
    /// </summary>
    [Flags()]
    public enum NotificationType
    {
        /// <summary>
        /// None.
        /// </summary>
        [Name("None", "NOTIFICATION_TYPE_NONE")]
        None = 0,

        /// <summary>
        /// Visual.
        /// </summary>
        [Name("Visual", "NOTIFICATION_TYPE_VISUAL")]
        Visual = 1,

        /// <summary>
        /// Audible.
        /// </summary>
        [Name("Audible", "NOTIFICATION_TYPE_AUDIBLE")]
        Audible = 2,

        /// <summary>
        /// Visual and Audible.
        /// </summary>
        [Name("Visual And Audible", "NOTIFICATION_TYPE_VISUAL_AND_AUDIBLE")]
        VisualAndAudible = Visual | Audible,
    }
}
