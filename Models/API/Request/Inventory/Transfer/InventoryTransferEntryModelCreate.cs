namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory transfer entry model create.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class InventoryTransferEntryModelCreate : IInventoryEntryModelCreate
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int ProductId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public decimal Quantity { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public string? Note { get; init; }
    }
}
