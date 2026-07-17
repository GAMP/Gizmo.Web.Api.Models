using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A user's challenges view — the visible challenges with the user's per-challenge
    /// standing, plus each involved achievement once with its window-independent live data.
    /// </summary>
    /// <remarks>
    /// Endpoints return null instead of a model when the user is unknown. Visible
    /// challenges are the currently open ones plus any (including ended or paused) the
    /// user has completions on; hidden challenges appear only once the user has
    /// completions on them.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementChallengesModel : IWebApiModel
    {
        /// <summary>
        /// The achievements involved in the view, once each — requirement rows reference
        /// them by achievement id. Completion counts are per challenge window and live on
        /// the requirement rows instead.
        /// </summary>
        [MessagePack.Key(0)]
        public IReadOnlyList<UserAchievementChallengeAchievementModel> Achievements { get; init; } = System.Array.Empty<UserAchievementChallengeAchievementModel>();

        /// <summary>
        /// The visible challenges with the user's standing.
        /// </summary>
        [MessagePack.Key(1)]
        public IReadOnlyList<UserAchievementChallengeModel> Challenges { get; init; } = System.Array.Empty<UserAchievementChallengeModel>();
    }
}
