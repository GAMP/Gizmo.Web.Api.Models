namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Exception model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LogExceptionModel
    {
        /// <summary>
        /// Empty result.
        /// </summary>
        public static readonly LogExceptionModel Empty = new LogExceptionModel();

        /// <summary>
        /// Exception.
        /// </summary>
        [MessagePack.Key(0)]
        public string? Exception { get; init; } = null;
    }
}
