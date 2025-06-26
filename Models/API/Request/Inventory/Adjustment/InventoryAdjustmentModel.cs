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
        [MessagePack.Key(7)]
        public int? InvoiceId { get; init; }

        /// <summary>
        /// Adjustment type.
        /// </summary>
        [MessagePack.Key(8)]
        public InventoryAdjustmentType AdjustmentType { get; init; }
    }
}
