using System.IO;

using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Directory enumeration parameters model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class DirectoryEnumerateParametersModel : IUriParametersQuery
    {
        /// <summary>
        /// Enumeration path.
        /// </summary>
        [MessagePack.Key(0)]
        public required string Path { get; init; }

        /// <summary>
        /// Optional wildcard pattern for matching file/directory names (e.g. "*.txt").
        /// When null or empty, all entries are returned.
        /// </summary>
        [MessagePack.Key(1)]
        public string? Pattern { get; init; }

        /// <summary>
        /// File attributes to skip during enumeration.
        /// </summary>
        [MessagePack.Key(2)]
        public FileAttributes SkipAttributes { get; init; }
    }
}
