using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host of a reservation offer.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationOfferHostModel : IWebApiModel
    {
        /// <summary>
        /// Host id.
        /// </summary>
        [Key(0)]
        public int HostId { get; init; }

        /// <summary>
        /// Host group id.
        /// </summary>
        [Key(1)]
        public int HostGroupId { get; init; }

        /// <summary>
        /// Price of the host group offer for one host.
        /// </summary>
        [Key(2)]
        public decimal Price { get; init; }
    }
}
