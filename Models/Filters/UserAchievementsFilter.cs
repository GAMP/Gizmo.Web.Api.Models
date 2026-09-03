using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User achievements view query options.
    /// </summary>
    /// <remarks>
    /// A query model rather than bare parameters, so future knobs are additive properties —
    /// no signature churn across controllers and api clients.
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class UserAchievementsFilter : IUriParametersQuery
    {
        /// <summary>
        /// Whether to collect live progress — the expensive part, one signal measurement per
        /// measurable achievement below its instance cap. When false the full structure
        /// returns with recorded completions only and every measurement-derived field null;
        /// null always means "not collected", never zero.
        /// </summary>
        [MessagePack.Key(0)]
        public bool Progress { get; set; } = true;

        /// <summary>
        /// Whether to list achievements the user has earned that can no longer be earned —
        /// archived and paused ones. They are the user's history, so they are included by
        /// default: dropping them silently shrinks a trophy case an operator only meant to
        /// tidy. False lists what is currently earnable and nothing else.
        /// </summary>
        /// <remarks>
        /// It never widens the view: an achievement the user has no completions on stays
        /// hidden once archived or paused either way, and a hidden achievement still surfaces
        /// only once earned.
        /// </remarks>
        [MessagePack.Key(1)]
        public bool IncludeUnavailable { get; set; } = true;
    }
}
