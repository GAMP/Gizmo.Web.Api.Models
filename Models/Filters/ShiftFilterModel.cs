using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Shift filter model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ShiftFilterModel : IModelFilter<ShiftModel>
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
        /// Active shift.
        /// </summary>
        [MessagePack.Key(2)]
        public bool? IsActive { get; init; }

        /// <summary>
        /// Opertor id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? OperatorId { get; init; }

        /// <summary>
        /// Register id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? RegisterId { get; init; }
    }
}
