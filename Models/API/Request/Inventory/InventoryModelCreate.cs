namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory create model.
    /// </summary>
    [MessagePack.Union(0, typeof(InventoryInboundModelCreate))]
    [MessagePack.Union(1, typeof(InventoryTransferModelCreate))]
    [MessagePack.Union(2, typeof(InventoryAdjustmentModelCreate))]
    [MessagePack.MessagePackObject]
    public abstract class InventoryModelCreate : IWebApiModel
    {
        /// <summary>
        /// Stock id.
        /// </summary>
        [MessagePack.Key(0)]
        public int StockId { get; init; }

        /// <summary>
        /// Note.
        /// </summary>
        [MessagePack.Key(1)]
        public string? Note { get; init; }
    }
}
