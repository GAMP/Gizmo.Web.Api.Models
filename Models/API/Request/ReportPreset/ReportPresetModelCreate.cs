using System;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Report preset creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReportPresetModelCreate : IReportPresetModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        [Required()]
        [StringLength(45,MinimumLength =1)]
        public string Name { get; init; } = string.Empty;

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public Guid Report { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public string? Filters { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public ReportPresetRange Range { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public int DisplayOrder { get; init; }
    }
}
