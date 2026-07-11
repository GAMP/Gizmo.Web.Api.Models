namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// An achievement required to reach an achievement ladder level.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AchievementLadderRequirementModel : IWebApiModel
    {
        /// <summary>
        /// Required achievement id.
        /// </summary>
        [MessagePack.Key(0)]
        public int AchievementId { get; init; }

        /// <summary>
        /// Number of completions required within the ladder period.
        /// </summary>
        [MessagePack.Key(1)]
        public int RequiredCount { get; init; } = 1;
    }
}
