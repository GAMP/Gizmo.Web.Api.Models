using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Scrip process creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SystemScripProcessCreateModel : IWebApiModel
    {
        /// <summary>
        /// Script data.
        /// </summary>
        [Required()]
        [MessagePack.Key(0)]
        public string Script { get; init; } = null!;

        /// <summary>
        /// Wait for exit.
        /// </summary>        
        [MessagePack.Key(1)]
        public bool WaitForExit { get; init; }

        /// <summary>
        /// Wait timeout in seconds.
        /// </summary>
        /// <remarks>
        /// This value will only be used if <see cref="WaitForExit"/> is set to <see langword="true"/>.
        /// </remarks>
        [MessagePack.Key(2)]
        public int WaitTimeout { get; init; }

        /// <summary>
        /// Create no window.
        /// </summary>
        [MessagePack.Key(3)]
        public bool CreateNoWindow { get; init; }
    }
}
