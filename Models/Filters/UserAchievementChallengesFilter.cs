using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User challenges view query options.
    /// </summary>
    /// <remarks>
    /// A query model rather than bare parameters, so future knobs are additive properties —
    /// no signature churn across controllers and api clients.
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class UserAchievementChallengesFilter : IUriParametersQuery
    {
        /// <summary>
        /// Whether to collect live progress — window completion counts and live signal
        /// measurement. When false the structure, completions and reward states return with
        /// every progress-derived field null; null always means "not collected", never zero.
        /// </summary>
        [MessagePack.Key(0)]
        public bool Progress { get; set; } = true;

        /// <summary>
        /// Whether to list challenges the user has earned that can no longer be earned —
        /// archived, paused, and those whose window has closed. They are the user's history,
        /// so they are included by default: dropping them silently shrinks a trophy case an
        /// operator only meant to tidy. False lists what is currently open and nothing else.
        /// </summary>
        /// <remarks>
        /// It never widens the view: a challenge the user has no completions on stays hidden
        /// once closed either way, and a hidden challenge still surfaces only once earned.
        /// </remarks>
        [MessagePack.Key(1)]
        public bool IncludeUnavailable { get; set; } = true;
    }
}
