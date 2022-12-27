using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Task
{
    /// <summary>
    /// Application task process.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationTaskProcess
    {
        #region PROPERTIES

        /// <summary>
        /// The file name of the process.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        /// <summary>
        /// The arguments of the process.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(255)]
        public string Arguments { get; set; }

        /// <summary>
        /// The working directory of the process.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(255)]
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// The username of the process.
        /// </summary>
        [MessagePack.Key(3)]
        [StringLength(45)]
        public string Username { get; set; }

        /// <summary>
        /// The password of the process.
        /// </summary>
        [MessagePack.Key(4)]
        [StringLength(45)]
        public string Password { get; set; }

        /// <summary>
        /// Whether the process is awaited until exit.
        /// </summary>
        [MessagePack.Key(5)]
        public bool Wait { get; set; }

        /// <summary>
        /// Whether the process is invisible.
        /// </summary>
        [MessagePack.Key(6)]
        public bool NoWindow { get; set; }

        #endregion
    }
}