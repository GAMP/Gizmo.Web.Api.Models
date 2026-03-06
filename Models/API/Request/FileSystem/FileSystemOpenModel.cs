using System.IO;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File system open parameters model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FileSystemOpenModel : IUriParametersQuery
    {
        /// <summary>
        /// Full path of the file.
        /// </summary>
        [MessagePack.Key(0)]
        public required string Path { get; init; }

        /// <summary>
        /// File open mode.
        /// </summary>
        [MessagePack.Key(1)]
        public FileMode Mode { get; init; } = FileMode.Open;

        /// <summary>
        /// File share mode.
        /// </summary>
        [MessagePack.Key(2)]
        public FileShare Share { get; init; } = FileShare.Read;
    }
}
