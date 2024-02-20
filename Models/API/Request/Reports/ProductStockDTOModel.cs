namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product Stock Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class ProductStockDTOModel
    {
        /// <summary>
        /// Product Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        [MessagePack.Key(1)]
        public string? ProductName { get; set; }

        /// <summary>
        /// Initial number of items in stock.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Initial { get; set; }

        /// <summary>
        /// Number of items added in stock.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Added { get; set; }

        /// <summary>
        /// Number of items removed from stock.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Removed { get; set; }

        /// <summary>
        /// Manually set stock to specific number of items.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Set { get; set; }

        /// <summary>
        /// The number of items sold of the product.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal Sold { get; set; }

        /// <summary>
        /// The number of items returned of the product.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal Returned { get; set; }

        /// <summary>
        /// Number of items the stock left with.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal Final { get; set; }

        /// <summary>
        /// Difference between initial and final stock.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal Diff { get; set; }
    }
}
