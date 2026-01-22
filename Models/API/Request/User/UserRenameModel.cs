namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User rename model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserRenameModel : IWebApiModel
    {
        /// <summary>
        /// New username.
        /// </summary>
        [MessagePack.Key(0)]
        public required string NewUsername { get; init; }
    }
}
