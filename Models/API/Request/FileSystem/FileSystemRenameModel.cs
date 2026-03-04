namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File system rename parameters model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FileSystemRenameModel
    {
        /// <summary>
        /// Full path of the file or directory to rename.
        /// </summary>
        [MessagePack.Key(0)]
        public required string Path { get; init; }

        /// <summary>
        /// New name (not full path, just the name).
        /// </summary>
        [MessagePack.Key(1)]
        public required string NewName { get; init; }
    }
}
