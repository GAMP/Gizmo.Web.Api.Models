using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One ladder level with the user's progress toward it.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementLadderLevelModel : IWebApiModel
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
        /// Optional badge image id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? ImageId { get; init; }

        /// <summary>
        /// The score required to reach the level. Points mode only, null in requirements mode.
        /// </summary>
        [MessagePack.Key(3)]
        public int? Threshold { get; init; }

        /// <summary>
        /// The user's progress toward this level, 0–100. Levels at or below the user's
        /// current rank are always 100. Null when progress collection was not requested.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal? Progress { get; init; }

        /// <summary>
        /// The level's requirement checklist with the user's live progress per requirement.
        /// Requirements mode only, and only for levels above the user's current rank;
        /// null otherwise.
        /// </summary>
        [MessagePack.Key(5)]
        public IReadOnlyList<UserAchievementLadderRequirementModel>? Requirements { get; init; }
    }
}
