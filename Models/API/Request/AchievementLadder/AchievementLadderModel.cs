using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Achievement ladder model.
    /// </summary>
    /// <remarks>
    /// The ladder is a singleton by design — one ladder exists in the system, so the model
    /// carries no identifier and the same shape serves both read and update. Reading an
    /// unconfigured system returns a disabled default; the ladder row materializes on the
    /// first save. <see cref="Levels"/> are ordered lowest to highest — the list order is
    /// the hierarchy.
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class AchievementLadderModel : IWebApiModel
    {
        /// <summary>
        /// Calendar period progress accumulates within — week through year.
        /// </summary>
        [MessagePack.Key(0)]
        public CalendarPeriod Period { get; init; }

        /// <summary>
        /// Scoring mode. Both modes' configuration may be stored; the mode selects which
        /// is evaluated.
        /// </summary>
        [MessagePack.Key(1)]
        public AchievementLadderMode Mode { get; init; }

        /// <summary>
        /// Option flags.
        /// </summary>
        [MessagePack.Key(2)]
        public AchievementLadderOptionType Options { get; init; }

        /// <summary>
        /// Indicates if the ladder is enabled.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsEnabled { get; init; }

        /// <summary>
        /// Ladder levels, ordered lowest to highest. The list order is the hierarchy.
        /// </summary>
        [MessagePack.Key(4)]
        public IReadOnlyList<AchievementLadderLevelModel> Levels { get; init; } = [];

        /// <summary>
        /// Achievements participating in points-mode scoring. Null means none.
        /// </summary>
        [MessagePack.Key(5)]
        public IReadOnlyList<AchievementLadderEntryModel>? Achievements { get; init; }
    }
}
