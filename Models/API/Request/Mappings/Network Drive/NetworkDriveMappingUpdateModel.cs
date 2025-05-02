using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Network drive create/update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class NetworkDriveMappingUpdateModel : IWebApiModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Source.
        /// </summary>
        [MessagePack.Key(1)]
        public string Source { get; init; } = null!;

        /// <summary>
        /// Mount point.
        /// </summary>
        [MessagePack.Key(2)]
        public string MountPoint { get; init; } = null!;

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
