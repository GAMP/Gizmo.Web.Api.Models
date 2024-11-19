namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory adjustment create model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class InventoryAdjustmentModelCreate : InventoryModelCreate
    {
        /// <summary>
        /// Adjustment type.
        /// </summary>
        [MessagePack.Key(2)]
        public InventoryAdjustmentType AdjustmentType { get; init; }
    }
}
