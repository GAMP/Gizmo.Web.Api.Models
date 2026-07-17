namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// An achievement required to complete an achievement challenge.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AchievementChallengeRequirementModel : IWebApiModel
    {
        /// <summary>
        /// Required achievement id.
        /// </summary>
        [MessagePack.Key(0)]
        public int AchievementId { get; init; }

        /// <summary>
        /// Number of completions required within the challenge's effective counting window
        /// (configured start or creation time, through the configured end or unbounded).
        /// </summary>
        [MessagePack.Key(1)]
        public int RequiredCount { get; init; } = 1;
    }
}
