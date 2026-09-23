using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One ladder level transition of a user — lean history row. Ranks are event-time
    /// snapshots; group ids resolve to display data on the consumer side. Requirement
    /// snapshot detail is a future drill-down, anchored by <see cref="Id"/>.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementLadderEventModel : IWebApiModel, IModelIntIdentifier
    {
        /// <summary>
        /// Event id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// UTC event time.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime CreatedTime { get; init; }

        /// <summary>
        /// What triggered the transition. Direction derives from the ranks.
        /// </summary>
        [MessagePack.Key(2)]
        public AchievementLadderEventTrigger Trigger { get; init; }

        /// <summary>
        /// The ladder rank moved from, as it was at event time.
        /// </summary>
        [MessagePack.Key(3)]
        public int FromRank { get; init; }

        /// <summary>
        /// The ladder rank moved to, as it was at event time.
        /// </summary>
        [MessagePack.Key(4)]
        public int ToRank { get; init; }

        /// <summary>
        /// The user group moved from.
        /// </summary>
        [MessagePack.Key(5)]
        public int FromUserGroupId { get; init; }

        /// <summary>
        /// The user group moved to.
        /// </summary>
        [MessagePack.Key(6)]
        public int ToUserGroupId { get; init; }

        /// <summary>
        /// UTC start of the ladder period whose activity caused the transition.
        /// </summary>
        [MessagePack.Key(7)]
        public DateTime PeriodStart { get; init; }

        /// <summary>
        /// The period score at event time. Points mode only, null in requirements mode.
        /// </summary>
        [MessagePack.Key(8)]
        public int? Score { get; init; }
    }
}
