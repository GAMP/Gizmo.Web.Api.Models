using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Achievement challenge reward option flags.
    /// </summary>
    [Flags]
    public enum AchievementChallengeRewardOptionType
    {
        /// <summary>
        /// No options set.
        /// </summary>
        None = 0,

        /// <summary>
        /// Force manual (operator) fulfillment for a reward that would otherwise grant
        /// automatically. Redundant on product rewards, which always require fulfillment.
        /// </summary>
        ForceClaim = 1,
    }
}
