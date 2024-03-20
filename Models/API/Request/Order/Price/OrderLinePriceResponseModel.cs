using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order line price model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderLinePriceResponseModel : IWebApiModel
    {
        /// <summary>
        /// Line guid.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid Guid { get; init; }

        /// <summary>
        /// Total line price.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Price { get; init; }

        /// <summary>
        /// Total points price.
        /// </summary>
        [MessagePack.Key(2)]
        public int PointsPrice { get; init; }

        /// <summary>
        /// Allowed pay type.
        /// </summary>
        /// <remarks>
        /// This might not be equal to the request pay type in case the item cannot be purchased with specified type.
        /// </remarks>
        [MessagePack.Key(3)]
        public Gizmo.OrderLinePayType PayType
        {
            get;init;
        }
    }
}
