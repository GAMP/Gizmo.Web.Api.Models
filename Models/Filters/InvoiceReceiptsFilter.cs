using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters for POS invoice receipt rows.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class InvoiceReceiptsFilter : IModelFilter<InvoiceReceiptModel>
    {
        /// <summary>
        /// Cursor pagination options.
        /// </summary>
        [Key(0)]
        public ModelFilterPagination Pagination { get; set; } = new()
        {
            SortBy = nameof(InvoiceReceiptModel.Date),
            IsAsc = false
        };

        /// <summary>
        /// Receipt query mode.
        /// </summary>
        [System.ComponentModel.DataAnnotations.EnumValueValidation]
        [Key(1)]
        public InvoiceReceiptMode Mode { get; set; }

        /// <summary>
        /// Exact invoice identifier.
        /// </summary>
        [Key(2)]
        public int? InvoiceId { get; set; }

        /// <summary>
        /// Shift identifier.
        /// </summary>
        [Key(3)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// Register identifier.
        /// </summary>
        [Key(4)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Companion identifier.
        /// </summary>
        [Key(5)]
        public int? CompanionId { get; set; }

        /// <summary>
        /// Included related objects.
        /// </summary>
        [Key(6)]
        public List<string> Expand { get; set; } = [];

        /// <summary>
        /// Exact product order identifier.
        /// </summary>
        [Key(7)]
        public int? ProductOrderId { get; set; }
    }
}
