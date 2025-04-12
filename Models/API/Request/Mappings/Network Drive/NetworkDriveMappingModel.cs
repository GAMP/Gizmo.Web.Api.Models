namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Network drive mapping model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class NetworkDriveMappingModel : MappingModel
    {
        /// <summary>
        /// Use credentials.
        /// </summary>
        [MessagePack.Key(3)]
        public bool UseCredentials { get; init; }

        /// <summary>
        /// Username.
        /// </summary>
        [MessagePack.Key(4)]
        public string? Username { get; init; }

        /// <summary>
        /// Password.
        /// </summary>
        [MessagePack.Key(5)]
        public string? Password { get; init; }
    }
}
