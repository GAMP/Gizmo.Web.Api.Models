#nullable enable

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task notification.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationTaskNotification
    {
        #region PROPERTIES

        /// <summary>
        /// The title of the notification.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        [StringLength(255)]
        public string Title { get; set; } = null!;

        /// <summary>
        /// The message of the notification.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        [StringLength(65536)]
        public string Message { get; set; } = null!;

        /// <summary>
        /// Whether to wait until the user responds to the notification.
        /// </summary>
        [MessagePack.Key(2)]
        public bool Wait { get; set; }

        #endregion
    }
}