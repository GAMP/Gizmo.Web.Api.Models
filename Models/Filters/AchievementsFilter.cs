using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Achievements filter.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AchievementsFilter : IModelFilter<AchievementModel>
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
        /// Return achievements measuring the specified signal only.
        /// </summary>
        [MessagePack.Key(2)]
        public Guid? SignalGuid { get; init; }

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
        /// Search value matched against achievement name.
        /// </summary>
        [MessagePack.Key(5)]
        public string? SearchValue { get; set; }
    }
}
