using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation offer host model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ReservationOfferHostModel : IWebApiModel
    {
        /// <summary>
        /// Host id.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostId { get; init; }

        /// <summary>
        /// Host offer.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid? HostGroupOfferId { get; init; }
    }
}
