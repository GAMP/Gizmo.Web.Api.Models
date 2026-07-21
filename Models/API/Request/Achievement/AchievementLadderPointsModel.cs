namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One ladder association of an achievement — the points the achievement awards on
    /// that ladder. Computed, read-only; the association is configured through the ladder,
    /// never through the achievement.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AchievementLadderPointsModel : IWebApiModel
    {
        /// <summary>
        /// Ladder id.
        /// </summary>
        [MessagePack.Key(0)]
        public int LadderId { get; init; }

        /// <summary>
        /// Points awarded per completion on this ladder. Points mode only — ignored by
        /// requirements-mode ladders.
        /// </summary>
        [MessagePack.Key(1)]
        public int Points { get; init; }

        /// <summary>
        /// Whether the entry currently participates in the ladder's scoring.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsEnabled { get; init; }
    }
}
