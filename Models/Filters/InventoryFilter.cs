using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory filter.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class InventoryFilter : IModelFilter<InventoryModel>
    {
        ///<inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        ///<inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Gets or sets inventory type.
        /// </summary>
        [MessagePack.Key(2)]
        public InventoryType? Type { get; set; }

        /// <summary>
        /// Gets or sets stock id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? StockId { get; set; }
    }
}
