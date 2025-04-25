namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory adjustment entry model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class InventoryAdjustmentEntryModel : InventoryEntryModel, IInventoryEntryModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int InventoryId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int StockId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public int ProductId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public int StockTransactionId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public decimal Quantity { get; init; }

        /// <summary>
        /// Unit cost.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal UnitCost { get; init; }

        /// <summary>
        /// Total cost.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal TotalCost { get; init; }

        /// <summary>
        /// Unit price.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal UnitPrice { get; init; }

        /// <summary>
        /// Total price.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal TotalPrice { get; init; }

        /// <summary>
        /// Adjustment reason id.
        /// </summary>
        [MessagePack.Key(10)]
        public int? AdjustmentReasonId { get; init; }
    }
}
