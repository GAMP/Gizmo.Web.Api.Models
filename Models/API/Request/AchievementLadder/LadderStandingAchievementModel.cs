namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One achievement involved in the standing, with the user's live values — listed once in
    /// the standing's lookup collection; requirement rows reference it by achievement id.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LadderStandingAchievementModel : IWebApiModel
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
        /// Completions the user earned within the current period, including live completions
        /// not yet recorded. Null when not collected or frozen.
        /// </summary>
        [MessagePack.Key(2)]
        public int? CompletedCount { get; init; }

        /// <summary>
        /// The user's raw signal value within the achievement's current range instance, in the
        /// signal's native unit. Null when not collected, frozen, or the signal is orphaned.
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

        /// <summary>
        /// Hidden from customers. The customer surface masks the row's identity and live value
        /// ("hidden requirement") but never removes it from counts, bars or the badge ring —
        /// denominators are identical on both surfaces.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsHidden { get; init; }

        /// <summary>
        /// The achievement's score weight — points awarded per completion — when the ladder
        /// scores in points mode; null in requirements mode. Structural: ships regardless of
        /// progress collection.
        /// </summary>
        [MessagePack.Key(7)]
        public int? Points { get; init; }

        /// <summary>
        /// Points earned within the current period — whole completions plus fractional live
        /// credit, times <see cref="Points"/>. The standing's Score is exactly the sum of
        /// these, so a breakdown always reconciles to the displayed total. Null when not
        /// collected, frozen, or in requirements mode.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal? EarnedPoints { get; init; }
    }
}
