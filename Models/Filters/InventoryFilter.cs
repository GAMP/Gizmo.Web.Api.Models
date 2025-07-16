using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

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

        /// <summary>
        /// Return inventories where the date greater than or equal to the specified date.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return inventories where the date less than or equal to the specified date.
        /// </summary>
        [MessagePack.Key(5)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Gets or sets the operator id.
        /// </summary>
        [MessagePack.Key(6)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Completed inventories.
        /// </summary>
        /// <remarks>
        /// All inventories except transfers are completed by default. Transfers are completed when the inbound transfer is created.
        /// </remarks>
        [MessagePack.Key(7)]
        public bool? IsCompleted { get; set; }
    }
}
