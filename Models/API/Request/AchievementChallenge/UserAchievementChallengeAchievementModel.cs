namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One achievement involved in the user's challenges view, with its window-independent
    /// live data — listed once; requirement rows reference it by achievement id.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementChallengeAchievementModel : IWebApiModel
    {
        /// <summary>
        /// Achievement id.
        /// </summary>
        [MessagePack.Key(0)]
        public int AchievementId { get; init; }

        /// <summary>
        /// The achievement's display name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// The user's raw signal value within the achievement's current range instance,
        /// in the signal's native unit. Null when progress collection was not requested or
        /// the achievement is paused.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal? CurrentValue { get; init; }

        /// <summary>
        /// The achievement's target value per completion, in the signal's native unit.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal TargetValue { get; init; }

        /// <summary>
        /// The measurement unit of <see cref="CurrentValue"/> and <see cref="TargetValue"/> —
        /// drives their display formatting. Null when the signal has no registered provider.
        /// </summary>
        [MessagePack.Key(4)]
        public SignalUnit? Unit { get; init; }
    }
}
