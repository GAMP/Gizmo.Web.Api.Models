using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Achievement challenges filter.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AchievementChallengesFilter : IModelFilter<AchievementChallengeModel>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Return challenges requiring the specified achievement only.
        /// </summary>
        [MessagePack.Key(2)]
        public int? AchievementId { get; init; }

        /// <summary>
        /// Is disabled.
        /// </summary>
        [MessagePack.Key(3)]
        public bool? IsDisabled { get; init; }

        /// <summary>
        /// Is deleted.
        /// </summary>
        [MessagePack.Key(4)]
        public bool? IsDeleted { get; init; }

        /// <summary>
        /// Search value matched against challenge name.
        /// </summary>
        [MessagePack.Key(5)]
        public string? SearchValue { get; set; }
    }
}
