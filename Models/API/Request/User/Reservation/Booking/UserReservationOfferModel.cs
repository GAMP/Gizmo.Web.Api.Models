using System;
using System.Collections.Generic;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation offer of the current user: prices and the minimum payment.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationOfferModel : IWebApiModel
    {
        /// <summary>
        /// Offer id, used to book the offer.
        /// </summary>
        [Key(0)]
        public Guid OfferId { get; init; }

        /// <summary>
        /// Reservation start (UTC).
        /// </summary>
        [Key(1)]
        public DateTime Date { get; init; }

        /// <summary>
        /// Duration in minutes.
        /// </summary>
        [Key(2)]
        public int Duration { get; init; }

        /// <summary>
        /// Hosts of the offer with their prices.
        /// </summary>
        [Key(3)]
        public IEnumerable<UserReservationOfferHostModel> Hosts { get; init; } = Enumerable.Empty<UserReservationOfferHostModel>();

        /// <summary>
        /// Reservation fee; null when there is no fee.
        /// </summary>
        [Key(4)]
        public decimal? Fee { get; init; }

        /// <summary>
        /// Discount.
        /// </summary>
        [Key(5)]
        public decimal Discount { get; init; }

        /// <summary>
        /// Total to pay.
        /// </summary>
        [Key(6)]
        public decimal Total { get; init; }

        /// <summary>
        /// Minimum payment.
        /// </summary>
        [Key(7)]
        public decimal MinimumPayment { get; init; }
    }
}
