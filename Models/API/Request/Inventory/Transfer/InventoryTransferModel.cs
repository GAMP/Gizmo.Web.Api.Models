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
        public int TransferStockId { get; init; }

        /// <summary>
        /// Inbound inventory id.
        /// </summary>
        public int? InventoryInboundId { get; init; }
    }
}
