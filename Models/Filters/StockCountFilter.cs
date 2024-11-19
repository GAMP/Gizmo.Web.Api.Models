using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock count filter model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class StockCountFilter : IModelFilter<StockCountModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Gets or sets the shift id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? ShiftId { get; init; }

        /// <summary>
        /// Gets or sets the operator id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? OperatorId { get; init; }

        /// <summary>
        /// Gets or sets whether the stock count has unexpected entries.
        /// </summary>
        [MessagePack.Key(4)]
        public bool? HasUnexpected { get; init; }
    }
}
