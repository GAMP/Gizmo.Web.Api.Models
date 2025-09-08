using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User cart state model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserCartStateModel : IWebApiModel
    {
        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; set; }

        /// <summary>
        /// Entries.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<CartEntryModel> Entries { get; set; } = Enumerable.Empty<CartEntryModel>();

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int PointsTotal { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public decimal SubTotal { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public decimal TaxTotal { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public decimal Discount { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public decimal Total { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(7)]
        public int PointsAward { get; init; }
    }
}
