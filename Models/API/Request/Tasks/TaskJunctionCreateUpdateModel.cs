using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Task junction create update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TaskJunctionCreateUpdateModel : IWebApiModel
    {
        /// <summary>
        /// Task name.
        /// </summary>
        [StringLength(45)]
        [Required()]
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Source directory.
        /// </summary>
        [StringLength(255)]
        [Required()]
        [MessagePack.Key(1)]
        public string SourceDirectory { get; set; } = null!;

        /// <summary>
        /// Destination directory.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string? DestinationDirectory { get; init; }

        /// <summary>
        /// Hide.
        /// </summary>
        [MessagePack.Key(3)]
        public bool DeleteDestination { get; init; }
    }
}
