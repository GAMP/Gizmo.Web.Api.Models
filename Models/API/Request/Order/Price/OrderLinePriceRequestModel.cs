using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order line prices calculation request model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderLinePriceRequestModel : IWebApiModel
    {
        /// <summary>
        /// Line guid.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid Guid { get; init; }

        /// <summary>
        /// Line type.
        /// </summary>
        [MessagePack.Key(1)]
        public LineType LineType { get; set; }

        /// <summary>
        /// Order line pay type.
        /// </summary>
        /// <remarks>
        /// This parameter indicates how this order line is expected to be paid.
        /// </remarks>
        [MessagePack.Key(2)]
        public Gizmo.OrderLinePayType PayType { get; set; }

        /// <summary>
        /// Whether to use the custom price for this order line. 
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsCustomPrice { get; set; }

        /// <summary>
        /// The custom price of the order line.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal? CustomPrice { get; set; }

        /// <summary>
        /// Line quantity.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The product object attached to this order line if the order line refers to a product, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(6)]
        public OrderLineProductModel? Product { get; set; }

        /// <summary>
        /// The time product object attached to this order line if the order line refers to a time product, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(7)]
        public OrderLineProductModel? TimeProduct { get; set; }

        /// <summary>
        /// The fixed time object attached to this order line if the order line refers to fixed time, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(8)]
        public OrderLineFixedTimeModel? FixedTime { get; set; }
    }
}
