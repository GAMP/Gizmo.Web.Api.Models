namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Cart entry product add model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartEntryProductAddModel : IWebApiModel
    {
        /// <summary>
        /// Quantity.
        /// </summary>
        [MessagePack.Key(0)]
        public decimal Quantity { get; init; }

        [MessagePack.Key(1)]
        public int ProductId { get; init; }

        /// <summary>
        /// Custom unit price.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal? UnitPrice { get; init; }

        /// <summary>
        /// Pay type.
        /// </summary>
        [MessagePack.Key(3)]
        public Gizmo.OrderLinePayType PayType { get; init; }

        /// <summary>
        /// Product mark.
        /// </summary>
        [MessagePack.Key(4)]
        public string? Mark { get; init; }
    }
}
