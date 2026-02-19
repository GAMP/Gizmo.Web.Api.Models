namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Current reservation confirmed result model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ReservationCurrentConfirmedResultModel : IWebApiModel
    {
        /// <summary>
        /// Confirmed result.
        /// </summary>
        [MessagePack.Key(0)]
        public ReservationCurrentConfirmedResult Result { get; init; }
    }
}
