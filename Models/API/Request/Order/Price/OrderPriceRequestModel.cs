using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order price request model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderPriceRequestModel : IWebApiModel
    {
        /// <summary>
        /// Order guid.
        /// </summary>
        /// <remarks>
        /// When calculating single order this value can be ommited.
        /// </remarks>
        [MessagePack.Key(1)]
        public Guid? Guid { get; init; }

        /// <summary>
        /// Optional user id.
        /// </summary>
        /// <remarks>
        /// Not specifying user will use guest prices.
        /// </remarks>
        [MessagePack.Key(2)]
        public int? UserId
        {
            get; init;
        }

        /// <summary>
        /// Order lines.
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<OrderLinePriceRequestModel> OrderLines { get; init; } = [];
    }
}
