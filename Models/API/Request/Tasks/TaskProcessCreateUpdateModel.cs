using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Task process create update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TaskProcessCreateUpdateModel : IWebApiModel
    {
        /// <summary>
        /// Task name.
        /// </summary>
        [StringLength(45)]
        [Required()]
        [MessagePack.Key(0)]
        public string Name { get; init; } = null!;

        /// <summary>
        /// File name.
        /// </summary>
        [StringLength(255)]
        [Required()]
        [MessagePack.Key(1)]
        public string FileName { get; set; } = null!;

        /// <summary>
        /// Working directory.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string? WorkingDirectory { get; init; }

        /// <summary>
        /// Arguments.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(3)]
        public string? Arguments { get; init; }

        /// <summary>
        /// Wait.
        /// </summary>
        [MessagePack.Key(4)]
        public bool Wait { get; init; }

        /// <summary>
        /// Hide.
        /// </summary>
        [MessagePack.Key(5)]
        public bool Hide { get;init; }
    }
}
