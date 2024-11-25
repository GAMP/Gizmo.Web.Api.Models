namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User permission model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserPermissionModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets the permission type.
        /// </summary>
        [MessagePack.Key(0)]
        public string Type { get; init; } = null!;

        /// <summary>
        /// Gets or sets the permission value.
        /// </summary>
        [MessagePack.Key(1)]
        public string Value { get; init; } = null!;
    }
}
