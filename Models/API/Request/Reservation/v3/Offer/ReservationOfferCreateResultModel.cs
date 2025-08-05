using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation offer model.
    /// </summary>
    /// <remarks>
    /// Describes a reservation offer with its id and price.
    /// </remarks>
    [MessagePack.MessagePackObject]
    public sealed class ReservationOfferCreateResultModel : IWebApiModel
    {
        /// <summary>
        /// Offer id.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid OfferId { get; init; }

        /// <summary>
        /// Offer price.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Price { get; init; }

        /// <summary>
        /// Reservation fee.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal? ReservationFee { get; init; }

        /// <summary>
        /// Total offer discount value.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Discount { get; init; }

        /// <summary>
        /// Total order reward value.
        /// </summary>
        [MessagePack.Key(4)]
        public int Reward { get; init; }

        /// <summary>
        /// Offers collection.
        /// </summary>
        /// <remarks>
        /// Hosts contained in <see cref="Hosts"/> will point to the offers contained in this offers collection.<br></br>
        /// This value will be empty in case no order can be generated.
        /// </remarks>
        [MessagePack.Key(5)]
        public IEnumerable<ReservationOfferHostGroupModel> Offers
        {
            get; set;
        } = Enumerable.Empty<ReservationOfferHostGroupModel>();

        /// <summary>
        /// Host reservation results.
        /// </summary>
        /// <remarks>
        /// Will contain a list of host and any available offers.
        /// </remarks>
        [MessagePack.Key(6)]
        public IEnumerable<ReservationOfferHostModel> Hosts
        {
            get; set;
        } = Enumerable.Empty<ReservationOfferHostModel>();

        /// <summary>
        /// Reservation duration.
        /// </summary>
        [MessagePack.Key(7)]
        public int Duration { get; init; }

        /// <summary>
        /// Reservation start.
        /// </summary>
        [MessagePack.Key(8)]
        public DateTime Start { get; init; }
    }
}
