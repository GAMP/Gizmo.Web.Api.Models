namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory entry model create.
    /// </summary>
    [MessagePack.Union(0, typeof(InventoryInboundEntryModelCreate))]
    [MessagePack.Union(1, typeof(InventoryAdjustmentModelCreate))]
    [MessagePack.Union(2, typeof(InventoryTransferEntryModelCreate))]
    [MessagePack.MessagePackObject]
    public abstract class InventoryEntryModelCreate : IWebApiModel
    {
    }
}
