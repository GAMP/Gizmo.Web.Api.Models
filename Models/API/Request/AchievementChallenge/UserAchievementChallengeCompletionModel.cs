using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One earned challenge completion with its reward grant states.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementChallengeCompletionModel : IWebApiModel
    {
        /// <summary>
        /// The user's 1-based completion number of the challenge.
        /// </summary>
        [MessagePack.Key(0)]
        public int Occurrence { get; init; }

        /// <summary>
        /// The 1-based global finisher number across all users.
        /// </summary>
        [MessagePack.Key(1)]
        public int GlobalOccurrence { get; init; }

        /// <summary>
        /// UTC completion time.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime CompletedTime { get; init; }

        /// <summary>
        /// Earned points rewards with their grant states.
        /// </summary>
        [MessagePack.Key(3)]
        public IReadOnlyList<UserAchievementChallengePointsRewardModel>? PointsRewards { get; init; }

        /// <summary>
        /// Earned product rewards with their grant states.
        /// </summary>
        [MessagePack.Key(4)]
        public IReadOnlyList<UserAchievementChallengeProductRewardModel>? ProductRewards { get; init; }

        /// <summary>
        /// Earned time rewards with their grant states.
        /// </summary>
        [MessagePack.Key(5)]
        public IReadOnlyList<UserAchievementChallengeTimeRewardModel>? TimeRewards { get; init; }
    }
}
