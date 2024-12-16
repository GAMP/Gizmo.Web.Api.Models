namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User permission set model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserPermissionSetModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Number of active permissions on this set.
        /// </summary>
        [MessagePack.Key(2)]
        public int Permissions { get; init; }

        /// <summary>
        /// Number of operators using this set.
        /// </summary>
        [MessagePack.Key(3)]
        public int Operators { get; init; }
    }
}
