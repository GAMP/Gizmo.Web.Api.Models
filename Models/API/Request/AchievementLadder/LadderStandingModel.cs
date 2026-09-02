using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A user's ladder standing — the single self-contained read model behind the level block
    /// on both the operator and customer surfaces.
    /// </summary>
    /// <remarks>
    /// <para>
    /// A standing is inherently per-user (user × ladder), which is why this family carries no
    /// "User" name prefix despite being a user view — there is no config counterpart to
    /// distinguish from, and the route (users/{userId}/standing) carries the user-ness.
    /// </para>
    /// <para>
    /// Response semantics: endpoints return null instead of a model when there is no level to
    /// display — no enabled ladder, the user's group is not a ladder level, or a guest. An
    /// unknown user id on the operator route fails the standard entity-not-found way, never
    /// null; banned and soft-deleted users return normal models. A tier-exempt user returns a
    /// model with <see cref="IsFrozen"/> set and every measurement-derived field null.
    /// </para>
    /// <para>
    /// The model is self-contained: every id it carries resolves within it — requirement rows
    /// join <see cref="Achievements"/> by achievement id, ranks index <see cref="Levels"/> —
    /// and nothing resolves through another endpoint. Image guids are asset references served
    /// by GET /files/{guid}, not data lookups.
    /// </para>
    /// <para>
    /// Progress collection is optional (?progress=false): the full structure is returned with
    /// every measurement-derived field null, uniformly — null always means "not collected",
    /// never zero. Held-since is deliberately not shipped: it is the newest transition's time
    /// when that transition's <see cref="LadderStandingTransitionModel.ToRank"/> equals
    /// <see cref="CurrentRank"/>.
    /// </para>
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class LadderStandingModel : IWebApiModel
    {
        /// <summary>
        /// The ladder scoring mode.
        /// </summary>
        [MessagePack.Key(0)]
        public AchievementLadderMode Mode { get; init; }

        /// <summary>
        /// The standing's state within the current period. Null when progress collection was
        /// not requested or the user is frozen.
        /// </summary>
        [MessagePack.Key(1)]
        public LadderStandingState? State { get; init; }

        /// <summary>
        /// The user is tier-exempt: the level is real and drives pricing, but never moves.
        /// Implies every measurement-derived field is null — frozen standings are never
        /// measured, regardless of the progress knob.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsFrozen { get; init; }

        /// <summary>
        /// The ladder's calendar period kind.
        /// </summary>
        [MessagePack.Key(3)]
        public CalendarPeriod PeriodKind { get; init; }

        /// <summary>
        /// UTC start of the current ladder period.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime PeriodStart { get; init; }

        /// <summary>
        /// UTC end of the current ladder period — the requalify-by moment.
        /// </summary>
        [MessagePack.Key(5)]
        public DateTime PeriodEnd { get; init; }

        /// <summary>
        /// Promotions are applied only at the period boundary settle instead of instantly.
        /// </summary>
        [MessagePack.Key(6)]
        public bool PromoteOnSettleOnly { get; init; }

        /// <summary>
        /// Promotions are capped at one level per period. Reserved — always false until
        /// stepwise promotion ships; <see cref="ProjectedRank"/> arrives already clamped by it.
        /// </summary>
        [MessagePack.Key(7)]
        public bool IsStepwise { get; init; }

        /// <summary>
        /// The rank of the user's current level — an index into <see cref="Levels"/>.
        /// </summary>
        [MessagePack.Key(8)]
        public int CurrentRank { get; init; }

        /// <summary>
        /// Where the user would land if the period ended now: the highest satisfied level
        /// ("highest satisfied wins", gaps allowed), clamped by stepwise promotion when active.
        /// Below <see cref="CurrentRank"/> this is the demotion forecast; above it, the
        /// promotion the evaluator would make. Null when not collected or frozen.
        /// </summary>
        [MessagePack.Key(9)]
        public int? ProjectedRank { get; init; }

        /// <summary>
        /// The user's live score within the current period, rounded to two decimals.
        /// Points mode only; null in requirements mode, when not collected, or frozen.
        /// </summary>
        [MessagePack.Key(10)]
        public decimal? Score { get; init; }

        /// <summary>
        /// The previous period's final score, rounded to two decimals. Null in requirements
        /// mode (which deliberately has no "last" equivalent — transitions carry that history),
        /// in the user's first-ever period, when not collected, or frozen. All null cases
        /// render identically: no reference marker.
        /// </summary>
        [MessagePack.Key(11)]
        public decimal? LastScore { get; init; }

        /// <summary>
        /// File guid of the ladder's badge template SVG, served by GET /files/{guid}.
        /// Null means the built-in template; a failed fetch degrades to the built-in too.
        /// </summary>
        [MessagePack.Key(12)]
        public Guid? TemplateGuid { get; init; }

        /// <summary>
        /// Every level on the ladder with the user's live completion of it, rank ascending.
        /// </summary>
        [MessagePack.Key(13)]
        public IReadOnlyList<LadderStandingLevelModel> Levels { get; init; } = Array.Empty<LadderStandingLevelModel>();

        /// <summary>
        /// The achievements involved in the standing, once each, name ascending — the lookup
        /// collection requirement rows reference by achievement id. Referential completeness is
        /// guaranteed: every referenced id is present.
        /// </summary>
        [MessagePack.Key(14)]
        public IReadOnlyList<LadderStandingAchievementModel> Achievements { get; init; } = Array.Empty<LadderStandingAchievementModel>();

        /// <summary>
        /// The newest level transitions, at most three, newest first. The full log lives on the
        /// paged ladder events endpoint.
        /// </summary>
        [MessagePack.Key(15)]
        public IReadOnlyList<LadderStandingTransitionModel> Transitions { get; init; } = Array.Empty<LadderStandingTransitionModel>();
    }
}
