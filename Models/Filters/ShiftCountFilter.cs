using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Shift count filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftCountFilter : IModelFilter<ShiftCountModel>
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
        /// Shift id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? ShiftId { get;init;}
    }
}
