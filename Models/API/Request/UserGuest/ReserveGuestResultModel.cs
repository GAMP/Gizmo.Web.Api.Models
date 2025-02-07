namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reserve guest result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReserveGuestResultModel : IWebApiModel
    {
        /// <summary>
        /// Reservation result.
        /// </summary>
        [MessagePack.Key(0)]
        public ReserveGuestResult Result { get; init; }

        /// <summary>
        /// Indicates that new guest user was created.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsNew { get; init; }

        /// <summary>
        /// Reserved user id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? UserId { get; init; }

        /// <summary>
        /// Slot.
        /// </summary>
        [MessagePack.Key(3)]
        public int? Slot { get; init; }
    }
}
