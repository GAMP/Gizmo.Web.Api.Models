namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Sold Product Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class SoldProductDTOModel
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
        /// The unit price of the product.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The unit cost of the product.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal UnitCost { get; set; }

        /// <summary>
        /// The number of items sold of the product.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The total cost of the products.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal TotalCost { get; set; }

        /// <summary>
        /// The cost of the product.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal Value { get; set; }

        /// <summary>
        /// The cost in points of the product.
        /// </summary>
        [MessagePack.Key(7)]
        public int PointsValue { get; set; }

        /// <summary>
        /// The points award of the product.
        /// </summary>
        [MessagePack.Key(8)]
        public int PointsAward { get; set; }

        /// <summary>
        /// The tax rate of the product.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal TaxRate { get; set; }

        /// <summary>
        /// The tax amount of the product.
        /// </summary>
        [MessagePack.Key(10)]
        public decimal Tax { get; set; }

        /// <summary>
        /// The product has been sold as part of a bundle.
        /// </summary>
        [MessagePack.Key(11)]
        public bool IsInBundle { get; set; }
    }
}
