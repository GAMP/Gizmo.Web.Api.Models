namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory create model.
    /// </summary>
    [MessagePack.Union(0, typeof(InventoryInboundCreateModel))]
    [MessagePack.Union(1, typeof(InventoryTransferCreateModel))]
    [MessagePack.Union(2, typeof(InventoryAdjustmentCreateModel))]
    [MessagePack.MessagePackObject]
    public abstract class InventoryCreateModel : IWebApiModel
    {

    }
}
