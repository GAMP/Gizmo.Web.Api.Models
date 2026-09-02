namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One level requirement — per-level facts only; the achievement's display name and live
    /// standing live once in <see cref="LadderStandingModel.Achievements"/>, referenced by
    /// <see cref="AchievementId"/>.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LadderStandingRequirementModel : IWebApiModel
    {
        /// <summary>
        /// The required achievement id — always resolvable in the standing's achievements
        /// lookup.
        /// </summary>
        [MessagePack.Key(0)]
        public int AchievementId { get; init; }

        /// <summary>
        /// Completions required within the ladder period.
        /// </summary>
        [MessagePack.Key(1)]
        public int RequiredCount { get; init; }

        /// <summary>
        /// The row was inherited from a lower level's requirement set. Reserved — always false
        /// until requirement inheritance ships; sets arrive already flattened and merged, the
        /// client only ever renders this as a provenance tag.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsInherited { get; init; }
    }
}
