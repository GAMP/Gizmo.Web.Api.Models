using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount group promotion model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PromotionDiscountGroupModel : PromotionModel, IWebApiModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Promotion name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Promotion description.
        /// </summary>
        [MessagePack.Key(2)]
        public string? Description { get; set; }

        /// <summary>
        /// Discount group id.
        /// </summary>
        [MessagePack.Key(3)]
        public int DiscountGroupId { get; set; }

        /// <summary>
        /// Promotion period.
        /// </summary>
        [MessagePack.Key(4)]
        public PeriodModel Period { get; set; } = new();

        /// <summary>
        /// Promotion limits.
        /// </summary>
        [MessagePack.Key(5)]
        public IEnumerable<PromotionLimitModel> Limits { get; set; } = Enumerable.Empty<PromotionLimitModel>();
    }
}
