namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User permission metadata model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserPermissionMetadataModel : IWebApiModel
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

        /// <summary>
        /// Gets or sets the permission group.
        /// </summary>
        [MessagePack.Key(2)]
        public string Group { get; init; } = null!;

        /// <summary>
        /// Gets or sets the permission name.
        /// </summary>
        [MessagePack.Key(3)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Gets or sets the permission description.
        /// </summary>
        [MessagePack.Key(4)]
        public string Description { get; init; } = null!;
    }
}
