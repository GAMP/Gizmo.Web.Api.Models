using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reserve guest result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReserveGuestResultModel : IWebApiModel
    {
        /// <summary>
        /// Creates new success result instance.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <param name="slot">Slot number.</param>
        /// <param name="isNew">New user flag.</param>
        public ReserveGuestResultModel(int userId, int? slot, bool isNew)
        {
            Result = ReserveGuestResult.Success;
            UserId = userId;
            Slot = slot;
            IsNew = isNew;
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="result">Result.</param> 
        /// <exception cref="ArgumentException">Thrown if <paramref name="result"/> value is equal to <see cref="ReserveGuestResult.Success"/></exception>
        public ReserveGuestResultModel(ReserveGuestResult result)
        {
            if (result == ReserveGuestResult.Success)
                throw new ArgumentException();

            Result = result;
        }

        /// <summary>
        /// Reservation result.
        /// </summary>
        [MessagePack.Key(0)]
        public ReserveGuestResult Result { get; }

        /// <summary>
        /// Indicates that new guest user was created.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsNew { get; }

        /// <summary>
        /// Reserved user id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? UserId { get; }

        /// <summary>
        /// Slot.
        /// </summary>
        [MessagePack.Key(3)]
        public int? Slot {  get; }
    }
}
