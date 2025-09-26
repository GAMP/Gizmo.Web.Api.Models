using System;
using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Single discount promotion model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PromotionDiscountModel : PromotionModel, IWebApiModel, IModelIntIdentifier
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
        /// Discount id.
        /// </summary>
        [MessagePack.Key(3)]
        public int DiscountId { get; set; }

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

        /// <summary>
        /// Promotion limits.
        /// </summary>
        [MessagePack.Key(6)]
        public IEnumerable<PromotionBranchModel> Branches { get; set; } = Enumerable.Empty<PromotionBranchModel>();

        /// <summary>
        /// Promotion code type.
        /// </summary>
        [MessagePack.Key(7)]
        public PromotionCodeType CodeType { get; set; }

        /// <summary>
        /// Promotion creation time.
        /// </summary>
        [MessagePack.Key(8)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Promotion is disabled.
        /// </summary>
        [MessagePack.Key(9)]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Promotion is deleted.
        /// </summary>
        [MessagePack.Key(10)]
        public bool IsDeleted { get; set; }
    }
}
