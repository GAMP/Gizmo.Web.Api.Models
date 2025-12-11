using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Task script create update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TaskScriptCreateUpdateModel : IWebApiModel
    {
        /// <summary>
        /// Task name.
        /// </summary>
        [StringLength(45)]
        [Required()]
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// Script type.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(1)]
        public TaskType Type { get; set; }

        /// <summary>
        /// Script.
        /// </summary>
        [Required()]
        [MessagePack.Key(2)]
        public string Script { get; init; } = null!;

        /// <summary>
        /// Wait.
        /// </summary>
        [MessagePack.Key(3)]
        public bool Wait { get; init; }

        /// <summary>
        /// Hide.
        /// </summary>
        [MessagePack.Key(4)]
        public bool Hide { get; init; }
    }
}
