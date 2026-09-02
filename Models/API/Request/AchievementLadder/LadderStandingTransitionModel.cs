using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One recent level transition within a standing — a purpose-built row, deliberately not
    /// the ladder event log model. Ranks are historical snapshots; joining them to the
    /// standing's current levels for names is current-config best effort.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LadderStandingTransitionModel : IWebApiModel
    {
        /// <summary>
        /// UTC time of the transition.
        /// </summary>
        [MessagePack.Key(0)]
        public DateTime Time { get; init; }

        /// <summary>
        /// The rank moved from, as it was at the time.
        /// </summary>
        [MessagePack.Key(1)]
        public int FromRank { get; init; }

        /// <summary>
        /// The rank moved to, as it was at the time.
        /// </summary>
        [MessagePack.Key(2)]
        public int ToRank { get; init; }

        /// <summary>
        /// What caused the transition. Only Live and Settle occur here — operator moves are
        /// audited in the users audit, never in the ladder event log.
        /// </summary>
        [MessagePack.Key(3)]
        public AchievementLadderEventTrigger Trigger { get; init; }
    }
}
