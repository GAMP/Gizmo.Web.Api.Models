namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Server instance information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InstanceInfoModel : IWebApiModel
    {
        /// <summary>
        /// Server version.
        /// </summary>
        [MessagePack.Key(0)]
        public string Version { get; init; } = null!;

        /// <summary>
        /// Operating system platform the server is running on.
        /// </summary>
        [MessagePack.Key(1)]
        public OSPlatform Platform { get; init; }

        /// <summary>
        /// Hosting mode of this server instance.
        /// </summary>
        [MessagePack.Key(2)]
        public HostingMode Hosting { get; init; }
    }
}
