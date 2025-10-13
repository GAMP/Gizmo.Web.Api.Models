using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation order model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReservationOrderModel : IWebApiModel, IOrderTotals
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public decimal SubTotal { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public decimal TaxTotal { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int PointsTotal { get; init; }

        /// <summary>
        /// Fee total.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Fee { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public decimal Discount { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public decimal Total { get; init; }

        /// <summary>
        /// Amount paid.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal Paid { get; init; }

        /// <summary>
        /// Outstanding.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal Outstanding { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(8)]
        public int PointsAward { get; init; }

        /// <summary>
        /// Reservation payment status.
        /// </summary>
        [MessagePack.Key(9)]
        public ReservationPaymentStatus PaymentStatus { get; init; }

        /// <summary>
        /// Invoice payment status.
        /// </summary>
        [MessagePack.Key(10)]
        public InvoiceStatus InvoiceStatus { get; init; }

        /// <summary>
        /// Payments.
        /// </summary>
        [MessagePack.Key(11)]
        public IEnumerable<ReservationInvoicePaymentModel> Payments { get; init; } = Enumerable.Empty<ReservationInvoicePaymentModel>();
    }
}
