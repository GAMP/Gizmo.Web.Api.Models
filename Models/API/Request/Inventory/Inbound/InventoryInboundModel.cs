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
        [MessagePack.Key(9)]
        public decimal Cost { get; init; }
    }
}
