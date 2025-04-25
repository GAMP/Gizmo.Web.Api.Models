namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Transfer inbound inventory creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InventoryTransferInboundModelCreate
    {
        /// <summary>
        /// Inventory transfer id.
        /// </summary>
        [MessagePack.Key(0)]
        public int InventoryTransferId { get; set; }
    }
}
