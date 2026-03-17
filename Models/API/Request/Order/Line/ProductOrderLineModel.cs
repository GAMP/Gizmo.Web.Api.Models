namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product order line model.
    /// </summary>
    [MessagePack.Union(0, typeof(ProductOrderLineFixedTimeModel))]
    [MessagePack.Union(1, typeof(ProductOrderLineTimeModel))]
    [MessagePack.Union(2, typeof(ProductOrderLineSessionModel))]
    [MessagePack.Union(3, typeof(ProductOrderLineReservationFeeModel))]
    [MessagePack.Union(4, typeof(ProductOrderLineProductModel))]
    public abstract class ProductOrderLineModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract int Id { get; init; }

        /// <summary>
        /// The pay type of the order line.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract OrderLinePayType PayType { get; init; }

        /// <summary>
        /// The name of the item in the order line.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract string ProductName { get; init; }

        /// <summary>
        /// The quantity of items in the order line.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract decimal Quantity { get; init; }

        /// <summary>
        /// The price for one unit in this order line.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract decimal UnitPrice { get; init; }

        /// <summary>
        /// The tax rate of the order line.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract decimal TaxRate { get; init; }

        /// <summary>
        /// The total amount excluding tax.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract decimal PreTaxTotal { get; init; }

        /// <summary>
        /// The total tax of the order line.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract decimal TaxTotal { get; init; }

        /// <summary>
        /// The total amount of the order line.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract decimal Total { get; init; }

        /// <summary>
        /// The cost in points for one unit in this order line.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract int UnitPointsPrice { get; init; }

        /// <summary>
        /// The total cost in points of the order line.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract int PointsTotal { get; init; }

        /// <summary>
        /// The amount of points the user earns from one unit in this order line.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract int? UnitPointsAward { get; init; }

        /// <summary>
        /// The total amount of points the user earns from this invoice line.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract int? PointsAwardTotal { get; init; }

        /// <summary>
        /// The cost of one unit in this order line.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract decimal? UnitCost { get; init; }

        /// <summary>
        /// The total cost of this order line.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract decimal? Cost { get; init; }

        /// <summary>
        /// Whether all the items of the order line have been delivered.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract bool IsDelivered { get; init; }

        /// <summary>
        /// The quantity of items that have been delivered.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract decimal DeliveredQuantity { get; init; }

        /// <summary>
        /// Total discount.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public abstract decimal Discount { get; init; }

    }
}
