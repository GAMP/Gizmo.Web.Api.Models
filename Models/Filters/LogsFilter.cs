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
        public CompareRangeOptions? DateCompareOption { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(3)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(5)]
        public LogMessageType? MessageType { get; set; } = null;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(6)]
        public ModuleType? ModuleType { get; set; } = null;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(7)]
        public CompareStringOptions? MessageCompareOption { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(8)]
        public string? Message { get; set; }
    }
}
