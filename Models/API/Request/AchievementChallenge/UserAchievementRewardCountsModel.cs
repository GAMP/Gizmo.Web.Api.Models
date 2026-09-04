namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// How many earned rewards sit in each status — the counts behind a rewards list header,
    /// which its paged rows cannot supply.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementRewardCountsModel : IWebApiModel
    {
        /// <summary>
        /// Total rewards.
        /// </summary>
        [MessagePack.Key(0)]
        public int Total { get; init; }

        /// <summary>
        /// Rewards awaiting automatic delivery.
        /// </summary>
        [MessagePack.Key(1)]
        public int Pending { get; init; }

        /// <summary>
        /// Rewards waiting to be claimed.
        /// </summary>
        [MessagePack.Key(2)]
        public int AwaitingClaim { get; init; }

        /// <summary>
        /// Rewards delivered automatically.
        /// </summary>
        [MessagePack.Key(3)]
        public int Delivered { get; init; }

        /// <summary>
        /// Rewards claimed.
        /// </summary>
        [MessagePack.Key(4)]
        public int Claimed { get; init; }

        /// <summary>
        /// Rewards declined.
        /// </summary>
        [MessagePack.Key(5)]
        public int Declined { get; init; }
    }
}
