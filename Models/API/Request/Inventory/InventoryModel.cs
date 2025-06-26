using System;
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
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public DateTime Date { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int StockId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public int? OperatorId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public int? ShiftId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public string? Note { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public IEnumerable<int> Documents { get; init; } = Enumerable.Empty<int>();
    }
}
