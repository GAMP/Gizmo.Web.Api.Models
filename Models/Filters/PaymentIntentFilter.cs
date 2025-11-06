using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment intent filter.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class PaymentIntentFilter : IModelFilter<PaymentIntentModel>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public List<string> Expand { get; set; } = new();

        /// <summary>
        /// Intent state.
        /// </summary>
        [MessagePack.Key(2)]
        public PaymentIntentState? State { get; set; }

        /// <summary>
        /// Date from.
        /// </summary>
        [MessagePack.Key(3)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Date to.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? BranchId { get; set; }

        /// <summary>
        /// Operator id.
        /// </summary>
        [MessagePack.Key(6)]
        public int? CreatedById { get; set; }

        /// <summary>
        /// Payment method id.
        /// </summary>
        [MessagePack.Key(7)]
        public int? PaymentMethodId { get; set; }
    }
}
