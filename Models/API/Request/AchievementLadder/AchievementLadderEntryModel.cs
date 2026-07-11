namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// An achievement participating in points-mode ladder scoring.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AchievementLadderEntryModel : IWebApiModel
    {
        /// <summary>
        /// Achievement id.
        /// </summary>
        [MessagePack.Key(0)]
        public int AchievementId { get; init; }

        /// <summary>
        /// Points awarded per completion.
        /// </summary>
        [MessagePack.Key(1)]
        public int Points { get; init; }

        /// <summary>
        /// Indicates if the entry contributes to scoring. Disabled entries keep their
        /// configuration but award nothing.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsEnabled { get; init; } = true;
    }
}
