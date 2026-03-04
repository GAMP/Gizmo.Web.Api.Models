namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Batch file download parameters model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FileSystemDownloadBatchModel
    {
        /// <summary>
        /// Full paths of the files or directories to download.
        /// </summary>
        [MessagePack.Key(0)]
        public required string[] Paths { get; init; }
    }
}
