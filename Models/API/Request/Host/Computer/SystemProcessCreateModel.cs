namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Process creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SystemProcessCreateModel : IWebApiModel
    {
        /// <summary>
        /// Process file name.
        /// </summary>
        [MessagePack.Key(0)]
        public string FileName { get; init; } = null!;

        /// <summary>
        /// Working directory.
        /// </summary>
        [MessagePack.Key(1)]
        public string? WorkingDirectory { get; init; }

        /// <summary>
        /// Arguments.
        /// </summary>
        [MessagePack.Key(2)]
        public string Arguments { get; init; } = null!;

        /// <summary>
        /// Wait for termination.
        /// </summary>        
        [MessagePack.Key(3)]
        public bool WaitForTermination { get; init; }

        /// <summary>
        /// Wait timeout.
        /// </summary>
        /// <remarks>
        /// This value will only be used if <see cref="WaitForTermination"/> is set to <see langword="true"/>.
        /// </remarks>
        [MessagePack.Key(4)]
        public int WaitTimeout { get; init; }

        /// <summary>
        /// Create no window.
        /// </summary>
        [MessagePack.Key(5)]
        public bool CreateNoWindow { get; init; }

        /// <summary>
        /// Use shell execute.
        /// </summary>
        [MessagePack.Key(6)]
        public bool ShellExecute { get; init; }
    }
}
