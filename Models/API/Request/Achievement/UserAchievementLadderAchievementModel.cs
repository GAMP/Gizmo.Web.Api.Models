namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One achievement involved in the user's ladder view, with the user's live standing —
    /// listed once at the ladder level; requirement rows reference it by achievement id.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementLadderAchievementModel : IWebApiModel
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
        /// Completions the user earned within the current period, including live
        /// completions of the current range instance not yet recorded.
        /// Null when progress collection was not requested.
        /// </summary>
        [MessagePack.Key(2)]
        public int? CompletedCount { get; init; }

        /// <summary>
        /// The user's raw signal value within the achievement's current range instance,
        /// in the signal's native unit — the live "2 of 3" numerator.
        /// Null when progress collection was not requested.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal? CurrentValue { get; init; }

        /// <summary>
        /// The achievement's target value per completion, in the signal's native unit.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal TargetValue { get; init; }

        /// <summary>
        /// The measurement unit of <see cref="CurrentValue"/> and <see cref="TargetValue"/> —
        /// drives their display formatting. Null when the signal has no registered provider.
        /// </summary>
        [MessagePack.Key(5)]
        public SignalUnit? Unit { get; init; }
    }
}
