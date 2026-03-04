using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// File system operation result.
    /// </summary>
    [MessagePackObject]
    public sealed class FileSystemResultModel
    {
        /// <summary>
        /// Whether the operation succeeded.
        /// </summary>
        [Key(0)]
        public bool IsSuccess { get; init; }

        /// <summary>
        /// OS error code.
        /// </summary>
        [Key(1)]
        public int ErrorCode { get; init; }

        /// <summary>
        /// Error message.
        /// </summary>
        [Key(2)]
        public string? ErrorMessage { get; init; }

        /// <summary>
        /// Success result.
        /// </summary>
        public static readonly FileSystemResultModel Success = new() { IsSuccess = true };
    }
}
