using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Price of a host group for the period.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationHostGroupPriceModel : IWebApiModel
    {
        /// <summary>
        /// Host group id.
        /// </summary>
        [Key(0)]
        public int HostGroupId { get; init; }

        /// <summary>
        /// Price of the whole period for one host; null when the host group has no usable offer (its hosts cannot be booked).
        /// </summary>
        [Key(1)]
        public decimal? Price { get; init; }

        /// <summary>
        /// Reference price of one hour by the host group tariff from the start; null when there is no tariff. Display only.
        /// </summary>
        [Key(2)]
        public decimal? HourlyRate { get; init; }
    }
}
