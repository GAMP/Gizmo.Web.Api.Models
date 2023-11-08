using Gizmo.Web.Api.Models.Abstractions;
using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Log filter model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LogsFilter : IModelFilter<LogModel>, IModelFilterRange
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
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(3)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Module type.
        /// </summary>
        [MessagePack.Key(4)]
        public ModuleType? ModuleType { get; set; } = null;

        /// <summary>
        /// Filter message.
        /// </summary>
        [MessagePack.Key(5)]
        public string? Message { get; set; }
    }
}
