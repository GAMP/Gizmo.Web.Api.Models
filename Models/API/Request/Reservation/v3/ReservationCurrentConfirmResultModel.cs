namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation confirmation result model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ReservationCurrentConfirmResultModel : IWebApiModel
    {
        /// <summary>
        /// Confirmation result.
        /// </summary>
        [MessagePack.Key(0)]
        public ReservationCurrentConfirmResult Result { get; init; }
    }
}
