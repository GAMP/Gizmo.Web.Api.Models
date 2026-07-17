namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One level requirement — per-level facts only; the achievement's display name and
    /// live standing live once in <see cref="UserAchievementLadderModel.Achievements"/>,
    /// referenced by <see cref="AchievementId"/>.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementLadderRequirementModel : IWebApiModel
    {
        /// <summary>
        /// The required achievement id.
        /// </summary>
        [MessagePack.Key(0)]
        public int AchievementId { get; init; }

        /// <summary>
        /// Completions required within the ladder period.
        /// </summary>
        [MessagePack.Key(1)]
        public int RequiredCount { get; init; }

        /// <summary>
        /// The user's live progress toward satisfying this requirement, 0–100 — completed
        /// count plus the fractional progress of the current range instance, over the
        /// required count. Null when progress collection was not requested.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal? Progress { get; init; }
    }
}
