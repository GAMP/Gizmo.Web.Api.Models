namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory entry model.
    /// </summary>
    [MessagePack.Union(0, typeof(InventoryInboundEntryModel))]
    [MessagePack.Union(1, typeof(InventoryTransferEntryModel))]
    [MessagePack.Union(2, typeof(InventoryAdjustmentEntryModel))]
    public abstract class InventoryEntryModel : IWebApiModel
    {
    }
}
