namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File system move parameters model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FileSystemMoveModel
    {
        /// <summary>
        /// Full source path.
        /// </summary>
        [MessagePack.Key(0)]
        public required string SourcePath { get; init; }

        /// <summary>
        /// Full destination path.
        /// </summary>
        [MessagePack.Key(1)]
        public required string DestinationPath { get; init; }
    }
}
