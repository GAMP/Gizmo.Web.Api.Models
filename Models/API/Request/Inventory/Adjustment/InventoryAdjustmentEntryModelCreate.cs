namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory adjustment entry creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InventoryAdjustmentEntryModelCreate : IInventoryEntryModelCreate
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int ProductId { get;init;}

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public decimal Quantity { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public string? Note { get; init; }

        /// <summary>
        /// Adjustment reason.
        /// </summary>
        [MessagePack.Key(3)]
        public int? AdjustmentReasonId { get; init; }  
    }   
}
