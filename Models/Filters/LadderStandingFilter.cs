using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Ladder standing query options.
    /// </summary>
    /// <remarks>
    /// A query model rather than bare parameters, so future knobs are additive properties —
    /// no signature churn across controllers and api clients.
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class LadderStandingFilter : IUriParametersQuery
    {
        /// <summary>
        /// Whether to collect live progress — the expensive part, one signal measurement per
        /// involved achievement. When false the full structure returns with every
        /// measurement-derived field null, uniformly; null always means "not collected",
        /// never zero.
        /// </summary>
        [MessagePack.Key(0)]
        public bool Progress { get; set; } = true;
    }
}
