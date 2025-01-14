using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Task notification create update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TaskNotificationCreateUpdateModel
    {
        /// <summary>
        /// Task name.
        /// </summary>
        [StringLength(45)]
        [Required()]
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Title.
        /// </summary>
        [StringLength(255)]
        [Required()]
        [MessagePack.Key(1)]
        public string Title { get; set; } = null!;

        /// <summary>
        /// Message.
        /// </summary>
        [Required()]
        [MessagePack.Key(2)]
        public string Message { get; init; } = null!;

        /// <summary>
        /// Wait.
        /// </summary>
        [MessagePack.Key(3)]
        public bool Wait { get; init; }
    }
}
