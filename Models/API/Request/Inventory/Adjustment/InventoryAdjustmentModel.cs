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
        public int? InvoiceId { get; init; }

        /// <summary>
        /// Adjustment type.
        /// </summary>
        public InventoryAdjustmentType AdjustmentType { get; init; }
    }
}
