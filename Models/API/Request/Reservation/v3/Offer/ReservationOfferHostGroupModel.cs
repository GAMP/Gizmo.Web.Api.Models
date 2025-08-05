using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation host group offer model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ReservationOfferHostGroupModel : IWebApiModel
    {
        /// <summary>
        /// Offer id.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid OfferId { get; init; }

        /// <summary>
        /// Host group id.
        /// </summary>
        [MessagePack.Key(1)]
        public int HostGroupId { get; init; }

        /// <summary>
        /// Type.
        /// </summary>
        [MessagePack.Key(2)]
        public ReservationTimeSourceType Type { get; init; }

        /// <summary>
        /// Offer price.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal Price { get; init; }

        /// <summary>
        /// Total offer discount value.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Discount { get; init; }

        /// <summary>
        /// Total order reward value.
        /// </summary>
        [MessagePack.Key(5)]
        public int Reward { get; init; }
    }
}
