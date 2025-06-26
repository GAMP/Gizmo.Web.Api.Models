namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory transfer model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InventoryTransferModel : InventoryModel
    {
        /// <summary>
        /// Transfer stock id.
        /// </summary>
        [MessagePack.Key(7)]
        public int TransferStockId { get; init; }

        /// <summary>
        /// Inbound inventory id.
        /// </summary>
        [MessagePack.Key(8)]
        public int? InventoryInboundId { get; init; }
    }
}
