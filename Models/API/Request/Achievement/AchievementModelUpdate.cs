using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Achievement update model.
    /// </summary>
    /// <remarks>
    /// The signal and calendar range are deliberately not updatable — they define the
    /// deed's identity. To measure something else, create a new achievement and disable
    /// the old one.
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class AchievementModelUpdate : IAchievementModel, IModelIntIdentifier
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
        public decimal Value { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public int MaxCompletionsPerRange { get; init; } = 1;

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public AchievementOptionType Options { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public bool IsDisabled { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(9)]
        public int? ImageId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(7)]
        public AchievementFiltersModel? Filters { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(8)]
        public IReadOnlyList<AchievementParameterModel>? Parameters { get; init; }
    }
}
