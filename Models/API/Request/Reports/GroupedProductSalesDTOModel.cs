namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Sold Product Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class GroupedProductSalesDTOModel
    {
        /// <summary>
        /// The number of items sold of the product.
        /// </summary>
        [MessagePack.Key(0)]
        public decimal Sold { get; set; }

        /// <summary>
        /// The number of items returned of the product.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Returned { get; set; }

        /// <summary>
        /// The cost of the product.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Value { get; set; }

        /// <summary>
        /// The cost in points of the product.
        /// </summary>
        [MessagePack.Key(3)]
        public int PointsValue { get; set; }

        /// <summary>
        /// The points award of the product.
        /// </summary>
        [MessagePack.Key(4)]
        public int PointsAward { get; set; }

        /// <summary>
        /// The tax amount of the product.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Tax { get; set; }

        /// <summary>
        /// Product Id.
        /// </summary>
        [MessagePack.Key(6)]
        public int Id { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        [MessagePack.Key(7)]
        public string? ProductName { get; set; }
    }
}
