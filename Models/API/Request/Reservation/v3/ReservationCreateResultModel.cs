namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation create result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReservationCreateResultModel : CreateResult
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="pin">Pin.</param>
        public ReservationCreateResultModel(int id, string pin) : base(id)
        {
            Pin = pin;
        }

        /// <summary>
        /// Reservation pin.
        /// </summary>
        [MessagePack.Key(1)]
        public string Pin { get; }
    }
}
