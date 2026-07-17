namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One challenge requirement with the user's standing. Completion counts are scoped to
    /// the challenge window (a completion counts when its crossing moment falls inside);
    /// the achievement's display data lives once in
    /// <see cref="UserAchievementChallengesModel.Achievements"/>.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementChallengeRequirementModel : IWebApiModel
    {
        /// <summary>
        /// The required achievement id.
        /// </summary>
        [MessagePack.Key(0)]
        public int AchievementId { get; init; }

        /// <summary>
        /// Completions required per challenge completion.
        /// </summary>
        [MessagePack.Key(1)]
        public int RequiredCount { get; init; }

        /// <summary>
        /// The user's completions counted within the challenge window.
        /// Null when progress collection was not requested.
        /// </summary>
        [MessagePack.Key(2)]
        public int? CompletedCount { get; init; }

        /// <summary>
        /// The user's live progress toward this requirement's share of the next challenge
        /// completion, 0–100. Null when progress collection was not requested or no further
        /// completion is possible.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal? Progress { get; init; }
    }
}
