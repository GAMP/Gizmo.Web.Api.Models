using System.IO;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Mount point.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FileSystemMountPoint : IWebApiModel
    {
        /// <summary>
        /// Mount point path.
        /// </summary>
        [MessagePack.Key(0)]
        public required string Path { get; init; }

        /// <summary>
        /// Size.
        /// </summary>
        [MessagePack.Key(1)]
        public ulong TotalSize { get; init; }

        /// <summary>
        /// Available size.
        /// </summary>
        [MessagePack.Key(2)]
        public ulong AvailableSpace { get; init; }

        /// <summary>
        /// Format.
        /// </summary>
        [MessagePack.Key(3)]
        public string? Format { get; init; }

        /// <summary>
        /// Type.
        /// </summary>
        [MessagePack.Key(4)]
        public DriveType Type { get; init; }
    }
}
