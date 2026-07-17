using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// An earned points reward with its grant state.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UserAchievementChallengePointsRewardModel : IWebApiModel
    {
        /// <summary>
        /// Points amount.
        /// </summary>
        [MessagePack.Key(0)]
        public int Amount { get; init; }

        /// <summary>
        /// Grant lifecycle status.
        /// </summary>
        [MessagePack.Key(1)]
        public AchievementChallengeRewardStatus Status { get; init; }

        /// <summary>
        /// UTC time the reward reached its terminal state (granted or declined); null while
        /// pending or awaiting claim.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime? ProcessedTime { get; init; }
    }

    /// <summary>
    /// An earned product reward with its grant state.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UserAchievementChallengeProductRewardModel : IWebApiModel
    {
        /// <summary>
        /// Rewarded product id.
        /// </summary>
        [MessagePack.Key(0)]
        public int ProductId { get; init; }

        /// <summary>
        /// Rewarded quantity.
        /// </summary>
        [MessagePack.Key(1)]
        public int Quantity { get; init; }

        /// <summary>
        /// Grant lifecycle status — awaiting claim means "collect at the counter".
        /// </summary>
        [MessagePack.Key(2)]
        public AchievementChallengeRewardStatus Status { get; init; }

        /// <summary>
        /// UTC time the reward reached its terminal state (granted or declined); null while
        /// pending or awaiting claim.
        /// </summary>
        [MessagePack.Key(3)]
        public DateTime? ProcessedTime { get; init; }
    }

    /// <summary>
    /// An earned time reward with its grant state.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UserAchievementChallengeTimeRewardModel : IWebApiModel
    {
        /// <summary>
        /// Credited time amount in seconds.
        /// </summary>
        [MessagePack.Key(0)]
        public int Seconds { get; init; }

        /// <summary>
        /// Grant lifecycle status.
        /// </summary>
        [MessagePack.Key(1)]
        public AchievementChallengeRewardStatus Status { get; init; }

        /// <summary>
        /// UTC time the reward reached its terminal state (granted or declined); null while
        /// pending or awaiting claim.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime? ProcessedTime { get; init; }
    }
}
