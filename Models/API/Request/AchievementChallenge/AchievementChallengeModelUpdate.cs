using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Achievement challenge update model.
    /// </summary>
    /// <remarks>
    /// Edits affect future completions only — prizes already earned are never revisited.
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class AchievementChallengeModelUpdate : IAchievementChallengeModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [Required]
        [StringLength(45)]
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;

        /// <inheritdoc/>
        [StringLength(65535)]
        [MessagePack.Key(2)]
        public string? Description { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public DateTime? StartTime { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public DateTime? EndTime { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public int? MaxCompletions { get; init; } = 1;

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public AchievementChallengeOptionType Options { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(7)]
        public bool IsDisabled { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(8)]
        public int? ImageId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(9)]
        public IReadOnlyList<AchievementChallengeRequirementModel> Requirements { get; init; } = [];

        /// <inheritdoc/>
        [MessagePack.Key(10)]
        public IReadOnlyList<AchievementChallengePointsRewardModel>? PointsRewards { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(11)]
        public IReadOnlyList<AchievementChallengeProductRewardModel>? ProductRewards { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(12)]
        public IReadOnlyList<AchievementChallengeTimeRewardModel>? TimeRewards { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(13)]
        public int? GlobalMaxCompletions { get; init; }
    }
}
