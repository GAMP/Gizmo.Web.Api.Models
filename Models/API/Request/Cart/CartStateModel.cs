using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Cart state model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartStateModel : IWebApiModel, IOrderTotals
    {
        /// <summary>
        /// User carts.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<UserCartStateModel> Carts { get; set; } = Enumerable.Empty<UserCartStateModel>();

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int PointsTotal { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public decimal SubTotal { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public decimal TaxTotal { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public decimal Discount { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public decimal Total { get; init; } 

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public int PointsAward { get; init; }
    }
}
