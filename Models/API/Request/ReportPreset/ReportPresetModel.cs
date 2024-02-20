using System;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc cref="IReportPresetModel"/>
    [MessagePack.MessagePackObject()]
    public sealed class ReportPresetModel : IModelIntIdentifier, IReportPresetModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public string Name { get; init; } = string.Empty;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public Guid Report { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public string? Filters { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public ReportPresetRange Range { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public int DisplayOrder { get; init; }
    }
}
