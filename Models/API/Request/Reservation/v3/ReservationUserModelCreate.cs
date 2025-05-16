namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation user create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReservationUserModelCreate : IWebApiModel
    {
        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; init; }
    }
}
