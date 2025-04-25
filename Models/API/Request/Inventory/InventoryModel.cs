using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc cref="IInventoryModel"/>
    [MessagePack.Union(0, typeof(InventoryInboundModel))]
    [MessagePack.Union(1, typeof(InventoryTransferModel))]
    [MessagePack.Union(2, typeof(InventoryAdjustmentModel))]
    [MessagePack.MessagePackObject()]
    public abstract class InventoryModel : IInventoryModel
    {
        /// <inheritdoc/>
        public int Id { get; init; }

        /// <inheritdoc/>
        public int StockId { get; init; }

        /// <inheritdoc/>
        public int? ShiftId { get; init; }

        /// <inheritdoc/>
        public string? Note { get; init; }

        /// <inheritdoc/>
        public IEnumerable<int> Documents { get; init; } = Enumerable.Empty<int>();
    }
}
