namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory inbound create model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class InventoryInboundModelCreate : InventoryModelCreate
    {
        /// <summary>
        /// Cost.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Cost { get; init; }
    }
}
