namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory entry model.
    /// </summary>
    [MessagePack.Union(0, typeof(InventoryInboundEntryModel))]
    [MessagePack.Union(1, typeof(InventoryTransferEntryModel))]
    [MessagePack.Union(2, typeof(InventoryAdjustmentEntryModel))]
    [MessagePack.MessagePackObject]
    public abstract class InventoryEntryModel : IInventoryEntryModel
    {
        /// <inheritdoc/>
        public int StockId { get; init; }

        /// <inheritdoc/>
        public int ProductId { get; init; }

        /// <inheritdoc/>
        public int StockTransactionId { get; init; }

        /// <inheritdoc/>
        public decimal Quantity { get; init; }
    }
}
