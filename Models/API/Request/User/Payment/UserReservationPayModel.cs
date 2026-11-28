using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Request to pay a not paid reservation of the current user online.
    /// </summary>
    [MessagePackObject]
    public sealed class UserReservationPayModel : IWebApiModel
    {
        /// <summary>
        /// Reservation id.
        /// </summary>
        [Key(0)]
        public int ReservationId { get; set; }

        /// <summary>
        /// Online payment method id.
        /// </summary>
        [Key(1)]
        public int PaymentMethodId { get; set; }
    }
}
