using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File system set timestamps parameters model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FileSystemSetTimestampsModel
    {
        /// <summary>
        /// Full path of the file or directory.
        /// </summary>
        [MessagePack.Key(0)]
        public required string Path { get; init; }

        /// <summary>
        /// Creation time (UTC). Null means do not update.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime? CreatedUtc { get; init; }

        /// <summary>
        /// Last write time (UTC). Null means do not update.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime? ModifiedUtc { get; init; }

        /// <summary>
        /// Last access time (UTC). Null means do not update.
        /// </summary>
        [MessagePack.Key(3)]
        public DateTime? AccessedUtc { get; init; }
    }
}
