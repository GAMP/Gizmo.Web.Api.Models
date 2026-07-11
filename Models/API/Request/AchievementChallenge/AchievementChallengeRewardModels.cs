namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A points reward of an achievement challenge.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AchievementChallengePointsRewardModel : IWebApiModel
    {
        /// <summary>
        /// Points amount deposited to the user's points balance.
        /// </summary>
        [MessagePack.Key(0)]
        public int Amount { get; init; }

        /// <summary>
        /// Option flags.
        /// </summary>
        [MessagePack.Key(1)]
        public AchievementChallengeRewardOptionType Options { get; init; }
    }

    /// <summary>
    /// A product reward of an achievement challenge.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AchievementChallengeProductRewardModel : IWebApiModel
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
        public int Quantity { get; init; } = 1;

        /// <summary>
        /// Option flags.
        /// </summary>
        [MessagePack.Key(2)]
        public AchievementChallengeRewardOptionType Options { get; init; }
    }

    /// <summary>
    /// A time reward of an achievement challenge.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AchievementChallengeTimeRewardModel : IWebApiModel
    {
        /// <summary>
        /// Credited time amount in seconds.
        /// </summary>
        [MessagePack.Key(0)]
        public int Seconds { get; init; }

        /// <summary>
        /// Option flags.
        /// </summary>
        [MessagePack.Key(1)]
        public AchievementChallengeRewardOptionType Options { get; init; }
    }
}
