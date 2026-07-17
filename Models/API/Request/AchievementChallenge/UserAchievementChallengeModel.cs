using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One challenge with the user's standing — requirement progress, earned completions
    /// with their reward grant states, and the reward configuration on offer.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementChallengeModel : IWebApiModel
    {
        /// <summary>
        /// Challenge id.
        /// </summary>
        [MessagePack.Key(0)]
        public int ChallengeId { get; init; }

        /// <summary>
        /// Challenge name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Customer-facing description.
        /// </summary>
        [MessagePack.Key(2)]
        public string? Description { get; init; }

        /// <summary>
        /// Optional image id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? ImageId { get; init; }

        /// <summary>
        /// Optional window start (UTC); null means since creation.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime? StartTime { get; init; }

        /// <summary>
        /// Optional window end (UTC); null means evergreen.
        /// </summary>
        [MessagePack.Key(5)]
        public DateTime? EndTime { get; init; }

        /// <summary>
        /// Whether the challenge is paused — visible because the user has completions on
        /// it, but no new occurrences materialize while paused.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsDisabled { get; init; }

        /// <summary>
        /// Maximum completions per user within the window; null means unlimited.
        /// </summary>
        [MessagePack.Key(7)]
        public int? MaxCompletions { get; init; }

        /// <summary>
        /// Optional global completion pool size shared by all users.
        /// </summary>
        [MessagePack.Key(8)]
        public int? GlobalMaxCompletions { get; init; }

        /// <summary>
        /// Completions left in the global pool ("N prizes left"); null when the pool is
        /// uncapped.
        /// </summary>
        [MessagePack.Key(9)]
        public int? GlobalRemaining { get; init; }

        /// <summary>
        /// The user's materialized completions of this challenge.
        /// </summary>
        [MessagePack.Key(10)]
        public int CompletionsEarned { get; init; }

        /// <summary>
        /// The user's live progress toward the next completion, 0–100 — the weakest
        /// requirement gates it. Null when progress collection was not requested or no
        /// further completion is possible (user or global cap reached, window closed,
        /// challenge paused).
        /// </summary>
        [MessagePack.Key(11)]
        public decimal? Progress { get; init; }

        /// <summary>
        /// The challenge requirements with the user's per-requirement standing.
        /// </summary>
        [MessagePack.Key(12)]
        public IReadOnlyList<UserAchievementChallengeRequirementModel> Requirements { get; init; } = System.Array.Empty<UserAchievementChallengeRequirementModel>();

        /// <summary>
        /// Points rewards on offer per completion.
        /// </summary>
        [MessagePack.Key(13)]
        public IReadOnlyList<AchievementChallengePointsRewardModel>? PointsRewards { get; init; }

        /// <summary>
        /// Product rewards on offer per completion.
        /// </summary>
        [MessagePack.Key(14)]
        public IReadOnlyList<AchievementChallengeProductRewardModel>? ProductRewards { get; init; }

        /// <summary>
        /// Time rewards on offer per completion.
        /// </summary>
        [MessagePack.Key(15)]
        public IReadOnlyList<AchievementChallengeTimeRewardModel>? TimeRewards { get; init; }

        /// <summary>
        /// The user's earned completions with their reward grant states, ordered by
        /// occurrence.
        /// </summary>
        [MessagePack.Key(16)]
        public IReadOnlyList<UserAchievementChallengeCompletionModel> MyCompletions { get; init; } = System.Array.Empty<UserAchievementChallengeCompletionModel>();

        /// <summary>
        /// Whether the challenge was deleted from the catalog — visible because the user
        /// has completions on it (earned history survives catalog cleanup); no new
        /// completions materialize.
        /// </summary>
        [MessagePack.Key(17)]
        public bool IsDeleted { get; init; }
    }
}
