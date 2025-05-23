using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount group create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DiscountGroupModelCreate : IWebApiModel
    {
        /// <summary>
        /// Name.
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Discounts.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<DiscountGroupDiscountModel> Discounts { get; init; } = Enumerable.Empty<DiscountGroupDiscountModel>();
    }
}
