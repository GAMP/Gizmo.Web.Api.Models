namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reserved guest release model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReservedGuestReleaseModel : IWebApiModel
    {
        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; init; }

        /// <summary>
        /// Indicates success or failure.
        /// </summary>
        [MessagePack.Key(1)]
        public bool Success { get; init; }
    }
}
