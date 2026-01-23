namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User move model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserMoveModel : IWebApiModel
    {
        /// <summary>
        /// Move host id.
        /// </summary>
        [MessagePack.Key(0)]
        public required int HostId { get; set; }

        /// <summary>
        /// Optional slot.
        /// </summary>
        [MessagePack.Key(1)]
        public int? Slot { get; set; }
    }
}
