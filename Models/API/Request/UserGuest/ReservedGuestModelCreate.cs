namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reserved guest user creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReservedGuestModelCreate : IWebApiModel
    {
        /// <summary>
        /// Host id.
        /// </summary>
        /// <remarks>
        /// The newly reserved guest will be assigned to host specified by the id.
        /// </remarks>
        [MessagePack.Key(0)]
        public int? HostId { get; init; }

        /// <summary>
        /// User group id.
        /// </summary>
        /// <remarks>
        /// The newly reserved guest will be assigned to user group specified by the id.
        /// </remarks>
        [MessagePack.Key(1)]
        public int? UserGroupId { get; init; }

        /// <summary>
        /// Slot.
        /// </summary>
        /// <remarks>
        /// The newly reserved guest will be assigned to specified slot.
        /// </remarks>
        [MessagePack.Key(2)]
        public int? Slot { get; init; }
    }
}
