using System;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Report preset update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReportPresetModelUpdate : IReportPresetModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        [Required()]
        [StringLength(45, MinimumLength = 1)]
        public string Name { get; init; } = string.Empty;

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public Guid Report { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public string? Filters { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public ReportPresetRange Range { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public int DisplayOrder { get; init; }

    }
}
