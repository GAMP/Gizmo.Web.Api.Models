using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation offer accept model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class HostReservationOfferAcceptModel : IWebApiModel
    {
        /// <summary>
        /// Reservation offer id.
        /// </summary>
        [Required()]
        [MessagePack.Key(0)]
        public Guid OfferId { get; init; }

        /// <summary>
        /// Payment method id.
        /// </summary>
        [Required()]
        [MessagePack.Key(1)]
        public int PaymentMethodId { get; init; }

        /// <summary>
        /// Payment amount.
        /// </summary>
        [Required()]
        [MessagePack.Key(2)]
        public decimal PaymentAmount { get; init; }
    }
}
