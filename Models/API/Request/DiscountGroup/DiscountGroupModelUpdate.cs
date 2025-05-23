using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount group update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DiscountGroupModelUpdate : IWebApiModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id {get; init;}

        /// <summary>
        /// Name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Discounts.
        /// </summary>
        [MessagePack.Key(2)]
        public IEnumerable<DiscountGroupDiscountModel> Discounts { get; init; } = Enumerable.Empty<DiscountGroupDiscountModel>();
    }
}
