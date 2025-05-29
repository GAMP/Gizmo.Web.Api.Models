namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User guest virtual result model.
    /// </summary>

    [MessagePack.MessagePackObject()]
    public sealed class UserGuestVirtualResult : IWebApiModel
    {
        /// <summary>
        /// Reserved guest user Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? UserId { get; init; }

        /// <summary>
        /// Host id.
        /// </summary>
        [MessagePack.Key(1)]
        public int HostId { get; init; }

        /// <summary>
        /// Slot number.
        /// </summary>
        [MessagePack.Key(2)]
        public int Slot { get; init; }
    }
}
