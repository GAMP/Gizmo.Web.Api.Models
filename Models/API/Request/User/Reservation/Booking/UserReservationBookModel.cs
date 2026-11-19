using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Request to book a reservation offer paid from the user deposit or online.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationBookModel : IWebApiModel
    {
        /// <summary>
        /// Offer id.
        /// </summary>
        [Key(0)]
        public Guid OfferId { get; set; }

        /// <summary>
        /// Amount to pay from the deposit: from the minimum payment up to the total of the offer.
        /// </summary>
        [Key(1)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Online payment method id. When set, the booking is paid online for the whole total (the amount must be equal to the total);
        /// when not set, the amount is paid from the deposit.
        /// </summary>
        [Key(2)]
        public int? PaymentMethodId { get; set; }
    }
}
