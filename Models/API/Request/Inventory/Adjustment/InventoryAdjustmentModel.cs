namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory adjustment model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InventoryAdjustmentModel : InventoryModel
    {
        /// <summary>
        /// Invoice id.
        /// </summary>
        [MessagePack.Key(9)]
        public int? InvoiceId { get; init; }

        /// <summary>
        /// Adjustment type.
        /// </summary>
        [MessagePack.Key(10)]
        public InventoryAdjustmentType AdjustmentType { get; init; }
    }
}
