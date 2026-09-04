using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Earned reward counts filter — the scope the counts are taken over.
    /// </summary>
    /// <remarks>
    /// Deliberately not the list filter: counts are per status, so paging and a status
    /// selection would be dead fields here.
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class UserAchievementRewardCountsFilter : IUriParametersQuery
    {
        /// <summary>
        /// Count the specified user's rewards only; null counts every user's.
        /// </summary>
        [MessagePack.Key(0)]
        public int? UserId { get; set; }

        /// <summary>
        /// Count rewards earned from the specified challenge only.
        /// </summary>
        [MessagePack.Key(1)]
        public int? ChallengeId { get; init; }
    }
}
