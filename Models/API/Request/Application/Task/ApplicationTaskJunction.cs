using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Task
{
    /// <summary>
    /// Application task junction.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationTaskJunction
    {
        #region PROPERTIES

        /// <summary>
        /// The source directory of the junction.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        [StringLength(255)]
        public string SourceDirectory { get; set; }

        /// <summary>
        /// The destination directory of the junction.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        [StringLength(255)]
        public string DestinationDirectory { get; set; }

        /// <summary>
        /// Whether the junction deletes the destination.
        /// </summary>
        [MessagePack.Key(2)]
        public bool DeleteDestination { get; set; }

        #endregion
    }
}