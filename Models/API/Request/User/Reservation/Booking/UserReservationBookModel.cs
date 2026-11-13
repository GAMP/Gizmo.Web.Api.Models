using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Request to book a reservation offer paid from the user deposit.
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
    }
}
