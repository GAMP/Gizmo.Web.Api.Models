using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order price response model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderPriceResponseModel : IWebApiModel
    {
        /// <summary>
        /// Order guid.
        /// </summary>
        /// <remarks>
        /// When calculating single order this value can be ommited.
        /// </remarks>
        [MessagePack.Key(0)]
        public Guid? Guid { get; init; }

        /// <summary>
        /// The subtotal of the order line.
        /// </summary>
        [MessagePack.Key(0)]
        public decimal SubTotal { get; set; }

        /// <summary>
        /// The total tax of the order line.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// The total amount of the order.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Total { get; set; }

        /// <summary>
        /// The total cost in points of the order.
        /// </summary>
        [MessagePack.Key(3)]
        public int PointsTotal { get; set; }

        /// <summary>
        /// Order line prices.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<OrderLinePriceResponseModel> OrderLines { get; init; } = [];
    }
}
