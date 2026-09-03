using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Earned rewards filter.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UserAchievementRewardsFilter : IModelFilter<UserAchievementRewardModel>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Return the specified user's rewards only; null returns every user's.
        /// </summary>
        /// <remarks>
        /// The user-facing surface sets this to the caller, so a user can only ever page
        /// their own rewards.
        /// </remarks>
        [MessagePack.Key(2)]
        public int? UserId { get; set; }

        /// <summary>
        /// Return rewards earned from the specified challenge only.
        /// </summary>
        [MessagePack.Key(3)]
        public int? ChallengeId { get; init; }

        /// <summary>
        /// Return rewards in any of the specified statuses; empty returns every status.
        /// </summary>
        /// <remarks>
        /// A list because one presented state covers two stored ones — an undelivered reward
        /// waiting on the automatic path and one waiting at the counter read the same to a
        /// person, while staying distinct where it matters.
        /// </remarks>
        [MessagePack.Key(4)]
        public List<AchievementChallengeRewardStatus> Statuses { get; set; } = new();
    }
}
