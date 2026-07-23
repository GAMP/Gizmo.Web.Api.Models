using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Achievement create model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AchievementModelCreate : IAchievementModel
    {
        /// <inheritdoc/>
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <inheritdoc/>
        [StringLength(65535)]
        [MessagePack.Key(1)]
        public string? Description { get; init; }

        /// <summary>
        /// Identity of the signal the achievement measures. Immutable after creation.
        /// </summary>
        [MessagePack.Key(2)]
        public Guid SignalGuid { get; init; }

        /// <summary>
        /// Calendar range one completion is evaluated within. Immutable after creation.
        /// </summary>
        [MessagePack.Key(3)]
        public CalendarPeriod Range { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public decimal Value { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public int MaxCompletionsPerRange { get; init; } = 1;

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public AchievementOptionType Options { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(7)]
        public bool IsDisabled { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(8)]
        public int? ImageId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(9)]
        public AchievementFiltersModel? Filters { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(10)]
        public IReadOnlyList<AchievementParameterModel>? Parameters { get; init; }
    }
}
