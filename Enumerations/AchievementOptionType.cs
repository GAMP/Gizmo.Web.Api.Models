using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Achievement option flags.
    /// </summary>
    [Flags]
    public enum AchievementOptionType
    {
        /// <summary>
        /// No options set.
        /// </summary>
        None = 0,

        /// <summary>
        /// The achievement is not displayed to end users in client interfaces.
        /// Presentation only — a hidden achievement still evaluates and completes.
        /// </summary>
        Hidden = 1,
    }
}
