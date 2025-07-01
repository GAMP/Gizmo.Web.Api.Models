namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory transfer entry model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InventoryTransferEntryModel : InventoryEntryModel , IInventoryEntryModel
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
        /// Transfer reason id.
        /// </summary>
        /// <remarks>Built in types represented by <see cref="InventoryTransferReasons"/>.</remarks>
        [MessagePack.Key(6)]
        public int? TransferReasonId { get; init; }
    }
}
