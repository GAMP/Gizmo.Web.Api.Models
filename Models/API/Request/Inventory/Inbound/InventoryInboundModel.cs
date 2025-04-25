namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory inbound model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InventoryInboundModel : InventoryModel
    {
        /// <summary>
        /// Cost.
        /// </summary>
        public decimal Cost { get; init; }
    }
}
