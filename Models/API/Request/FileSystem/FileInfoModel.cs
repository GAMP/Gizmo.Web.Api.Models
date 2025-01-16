using System;
using System.IO;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File info model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FileInfoModel : IWebApiModel
    {
        /// <summary>
        /// File name.
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// File attributes.
        /// </summary>
        [MessagePack.Key(1)]
        public FileAttributes Attributes { get;init; }

        /// <summary>
        /// File length.
        /// </summary>
        [MessagePack.Key(2)]
        public long Length { get; init; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [MessagePack.Key(3)]
        public DateTimeOffset CreationTime { get; init; }

        /// <summary>
        /// Last access time.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTimeOffset LastAccessTime { get; init; }

        /// <summary>
        /// Last write time.
        /// </summary>
        [MessagePack.Key(5)]
        public DateTimeOffset LastWriteTime { get; init; }
    }
}
