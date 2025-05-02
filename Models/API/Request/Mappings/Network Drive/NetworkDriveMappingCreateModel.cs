namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Network drive create/update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class NetworkDriveMappingCreateModel : IWebApiModel
    {
        /// <summary>
        /// Source.
        /// </summary>
        [MessagePack.Key(0)]
        public string Source { get; init; } = null!;

        /// <summary>
        /// Mount point.
        /// </summary>
        [MessagePack.Key(1)]
        public string MountPoint { get; init; } = null!;

        /// <summary>
        /// Use credentials.
        /// </summary>
        [MessagePack.Key(2)]
        public bool UseCredentials { get; init; }

        /// <summary>
        /// Username.
        /// </summary>
        [MessagePack.Key(3)]
        public string? Username { get; init; }

        /// <summary>
        /// Password.
        /// </summary>
        [MessagePack.Key(4)]
        public string? Password { get; init; }
    }
}
