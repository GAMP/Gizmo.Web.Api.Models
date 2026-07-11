using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Achievement model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AchievementModel : IWebApiModel, IAchievementModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [StringLength(45)]
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;

        /// <inheritdoc/>
        [StringLength(65535)]
        [MessagePack.Key(2)]
        public string? Description { get; init; }

        /// <summary>
        /// Identity of the signal the achievement measures. Immutable after creation.
        /// </summary>
        [MessagePack.Key(3)]
        public Guid SignalGuid { get; init; }

        /// <summary>
        /// Calendar range one completion is evaluated within. Immutable after creation.
        /// </summary>
        [MessagePack.Key(4)]
        public CalendarPeriod Range { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public decimal Value { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public int MaxCompletionsPerRange { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(7)]
        public AchievementOptionType Options { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(8)]
        public bool IsDisabled { get; init; }

        /// <summary>
        /// Indicates that the achievement is deleted.
        /// </summary>
        [MessagePack.Key(9)]
        public bool IsDeleted { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(10)]
        public AchievementFiltersModel? Filters { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(11)]
        public IReadOnlyList<AchievementParameterModel>? Parameters { get; init; }
    }
}
