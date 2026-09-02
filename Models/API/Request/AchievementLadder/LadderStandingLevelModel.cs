using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One ladder level within a standing, with the user's live completion of it.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LadderStandingLevelModel : IWebApiModel
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
        /// Optional customer-facing level description. The operator surface does not render it.
        /// </summary>
        [MessagePack.Key(2)]
        public string? Description { get; init; }

        /// <summary>
        /// File guid of the level's emblem image, served by GET /files/{guid}. Any format, no
        /// authoring convention. A failed fetch degrades to the template's own rank art.
        /// </summary>
        [MessagePack.Key(3)]
        public Guid? EmblemGuid { get; init; }

        /// <summary>
        /// The score required to reach the level. Points mode only, null in requirements mode.
        /// </summary>
        [MessagePack.Key(4)]
        public int? Threshold { get; init; }

        /// <summary>
        /// The level's requirements in configuration order. Null in points mode (not
        /// applicable); an empty list is a level with zero requirements (the entry level).
        /// </summary>
        [MessagePack.Key(5)]
        public IReadOnlyList<LadderStandingRequirementModel>? Requirements { get; init; }

        /// <summary>
        /// What this level is worth, in server display order. Structure, not measurement —
        /// unaffected by the progress knob. Empty when the level confers no perks.
        /// </summary>
        [MessagePack.Key(6)]
        public IReadOnlyList<LadderStandingPerkModel> Perks { get; init; } = Array.Empty<LadderStandingPerkModel>();

        /// <summary>
        /// The user's live completion of this level, 0–100, rounded to two decimals. Points
        /// mode: score over threshold. Requirements mode: mean of the per-requirement
        /// fractions — partial work counts; <see cref="MetCount"/> is the authoritative gate
        /// count beside it. Null when not collected or frozen.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal? Progress { get; init; }

        /// <summary>
        /// Requirements fully met this period. The level is satisfied only when all are —
        /// <see cref="Progress"/> is feedback, this is the gate count. Null when not collected
        /// or frozen.
        /// </summary>
        [MessagePack.Key(8)]
        public int? MetCount { get; init; }

        /// <summary>
        /// Would the evaluator award this level right now? Null when not collected or frozen.
        /// </summary>
        [MessagePack.Key(9)]
        public bool? IsSatisfied { get; init; }
    }
}
