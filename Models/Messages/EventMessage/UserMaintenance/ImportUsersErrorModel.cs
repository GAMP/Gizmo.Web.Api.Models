using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Row-level user import error.
    /// </summary>
    [MessagePackObject]
    public sealed class ImportUsersErrorModel
    {
        /// <summary>
        /// Excel row number where the error was found.
        /// </summary>
        [Key(0)]
        public int RowNumber { get; init; }

        /// <summary>
        /// Field name associated with the error, when applicable.
        /// </summary>
        [Key(1)]
        public string? Field { get; init; }

        /// <summary>
        /// Error message.
        /// </summary>
        [Key(2)]
        public string Message { get; init; } = string.Empty;
    }
}
