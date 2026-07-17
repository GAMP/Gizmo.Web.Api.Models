namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A user's current achievement ladder level — the display basics.
    /// </summary>
    /// <remarks>
    /// Endpoints return null instead of a model when there is no level to display: no
    /// enabled ladder exists or the user's group is not a ladder level group. Progress
    /// (score, next level, period) is a separate, richer view.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementLevelModel : IWebApiModel
    {
        /// <summary>
        /// The level's position on the ladder — higher rank is a higher level.
        /// </summary>
        [MessagePack.Key(0)]
        public int Rank { get; init; }

        /// <summary>
        /// The level's display name — the name of the user group the level maps to.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Optional customer-facing level description (perk marketing copy).
        /// </summary>
        [MessagePack.Key(2)]
        public string? Description { get; init; }

        /// <summary>
        /// Optional badge image id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? ImageId { get; init; }

        /// <summary>
        /// Total number of levels on the ladder — enables "level 2 of 5" display.
        /// </summary>
        [MessagePack.Key(4)]
        public int TotalLevels { get; init; }
    }
}
