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
        /// The user's completions toward the next challenge completion, out of
        /// <see cref="RequiredCount"/>. Scoped to the occurrence in progress: what already
        /// earned occurrences consumed is subtracted, so this counts down to the next prize
        /// and starts over on each win rather than climbing across the whole run. Null when
        /// progress collection was not requested.
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

        /// <summary>
        /// Completions of the required achievement the calendar can still yield before the
        /// challenge window closes — the ceiling behind
        /// <see cref="UserAchievementChallengeState.Unreachable"/>. Null when the window is
        /// evergreen (capacity is unbounded) or progress collection was not requested.
        /// </summary>
        /// <remarks>
        /// Calendar capacity only: it deliberately ignores whether the achievement is
        /// currently paused or archived, because a pause is recoverable and reporting it here
        /// would present a temporary stop as a permanent one. That case surfaces as
        /// <see cref="UserAchievementChallengeState.Blocked"/> instead.
        /// </remarks>
        [MessagePack.Key(4)]
        public int? RemainingAchievable { get; init; }
    }
}
