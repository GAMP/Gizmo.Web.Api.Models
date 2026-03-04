namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File system delete parameters model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FileSystemDeleteModel
    {
        /// <summary>
        /// Full path of the file or directory to delete.
        /// </summary>
        [MessagePack.Key(0)]
        public required string Path { get; init; }

        /// <summary>
        /// Whether the target is a directory.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsDirectory { get; init; }
    }
}
