using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product stock level filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductStockLevelFilter : IModelFilter<StockLevelModel>
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Product id.
        /// </summary>
        [MessagePack.Key(2)]
        public string? ProductName { get; init; }

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? BranchId { get; init; }

        /// <summary>
        /// Stock id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? StockId { get; init; }

        /// <summary>
        /// Stock type.
        /// </summary>
        [MessagePack.Key(5)]
        public StockType? StockType { get; init; }

        /// <summary>
        /// Desired stock level.
        /// </summary>
        [MessagePack.Key(6)]
        public StockLevelType Level { get; set; } =  StockLevelType.Any;
    }
}
