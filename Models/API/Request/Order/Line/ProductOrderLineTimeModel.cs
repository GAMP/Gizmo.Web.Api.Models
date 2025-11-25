namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product order line time model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ProductOrderLineTimeModel : ProductOrderLineModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public override int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public override OrderLinePayType PayType { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public override string ProductName { get; init; } = null!;

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public override decimal Quantity { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public override decimal UnitPrice { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public override decimal TaxRate { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public override decimal PreTaxTotal { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(7)]
        public override decimal TaxTotal { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(8)]
        public override decimal Total { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(9)]
        public override int UnitPointsPrice { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(10)]
        public override int PointsTotal { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(11)]
        public override int? UnitPointsAward { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(12)]
        public override int? PointsAwardTotal { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(13)]
        public override decimal? UnitCost { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(14)]
        public override decimal? Cost { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(15)]
        public override bool IsDelivered { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(16)]
        public override decimal DeliveredQuantity { get; init; }

        /// <summary>
        /// Product time id.
        /// </summary>
        [MessagePack.Key(17)]
        public int ProductId { get; init; }

        /// <summary>
        /// Bundle line id.
        /// </summary>
        [MessagePack.Key(18)]
        public int? BundleLineId { get; init; }
    }
}
