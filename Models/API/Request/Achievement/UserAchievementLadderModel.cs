using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A user's ladder standing with per-level progress — the rich progress view behind
    /// level ladders and "road to the next rank" displays.
    /// </summary>
    /// <remarks>
    /// Progress is live: recorded completions plus the fractional progress of each
    /// achievement's current range instance, so the numbers move as the user plays.
    /// Endpoints return null instead of a model when there is nothing to display (no
    /// enabled ladder, unknown user, or the user's group is not a ladder level group).
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementLadderModel : IWebApiModel
    {
        /// <summary>
        /// The ladder scoring mode.
        /// </summary>
        [MessagePack.Key(0)]
        public AchievementLadderMode Mode { get; init; }

        /// <summary>
        /// The rank of the user's current level.
        /// </summary>
        [MessagePack.Key(1)]
        public int CurrentRank { get; init; }

        /// <summary>
        /// The user's live score within the current period.
        /// Used in points mode; null in requirements mode or when progress collection was
        /// not requested. Includes fractional credit from in-progress range instances, so
        /// it may exceed whole-completion arithmetic.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal? Score { get; init; }

        /// <summary>
        /// UTC start of the current ladder period.
        /// </summary>
        [MessagePack.Key(3)]
        public DateTime PeriodStart { get; init; }

        /// <summary>
        /// UTC end of the current ladder period — the requalify-by moment.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime PeriodEnd { get; init; }

        /// <summary>
        /// The ladder levels ordered by rank, each with the user's progress toward it.
        /// </summary>
        [MessagePack.Key(5)]
        public IReadOnlyList<UserAchievementLadderLevelModel> Levels { get; init; } = System.Array.Empty<UserAchievementLadderLevelModel>();

        /// <summary>
        /// The achievements involved in the view, once each, with the user's live standing —
        /// requirement rows reference them by achievement id.
        /// </summary>
        [MessagePack.Key(6)]
        public IReadOnlyList<UserAchievementLadderAchievementModel> Achievements { get; init; } = System.Array.Empty<UserAchievementLadderAchievementModel>();
    }
}
