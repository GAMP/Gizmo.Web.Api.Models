namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock level model.
    /// </summary>
    /// <remarks>
    /// Represents product stock levels based on stock.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class StockLevelModel : IWebApiModel
    {
        /// <summary>
        /// Stock id.
        /// </summary>
        [MessagePack.Key(0)]
        public int StockId { get; init; }

        /// <summary>
        /// The amount of stock.
        /// </summary>
        /// <remarks>
        /// Null value indicates that there are no stock transactions made for the product effectively meaning that the current stock level is unknown.
        /// </remarks>
        [MessagePack.Key(1)]
        public decimal? OnHand { get; set; }

        /// <summary>
        /// Indicates that product have reached alert level.
        /// </summary>
        [MessagePack.Key(2)]
        public bool AlertLevelReached { get; init; }
    }
}
