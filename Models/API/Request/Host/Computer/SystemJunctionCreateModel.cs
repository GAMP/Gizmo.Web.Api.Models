using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Junction creation model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SystemJunctionCreateModel : IWebApiModel
    {
        /// <summary>
        /// Source directory.
        /// </summary>
        [Required()]
        [MessagePack.Key(0)]
        public string SourceDirectory { get; init; } = null!;

        /// <summary>
        /// Destination directory.
        /// </summary>
        [Required()]
        [MessagePack.Key(1)]
        public string DestinationDirectory { get; init; } = null!;

        /// <summary>
        /// Delete destination.
        /// </summary>
        [MessagePack.Key(2)]
        public bool DeleteDestination { get; init; }
    }
}
