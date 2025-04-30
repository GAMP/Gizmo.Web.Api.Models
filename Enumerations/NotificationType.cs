using System;

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
        None = 0,
        /// <summary>
        /// Visual.
        /// </summary>
        Visual = 1,
        /// <summary>
        /// Audible.
        /// </summary>
        Audible = 2,
        /// <summary>
        /// Visual and Audible.
        /// </summary>
        VisualAndAudible = Visual | Audible,
    }
}
