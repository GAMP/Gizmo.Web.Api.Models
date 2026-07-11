using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Achievement ladder option flags.
    /// </summary>
    [Flags]
    public enum AchievementLadderOptionType
    {
        /// <summary>
        /// No options set.
        /// </summary>
        None = 0,

        /// <summary>
        /// Promotions are applied only at the period boundary settle instead of instantly —
        /// a period's activity decides the level held through the following period.
        /// </summary>
        PromoteOnSettleOnly = 1,
    }
}
