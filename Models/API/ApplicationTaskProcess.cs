using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task process.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationTaskProcess
    {
        #region PROPERTIES

        /// <summary>
        /// The file name of the process.
        /// </summary>
        [Required]
        [StringLength(255)]
        [MessagePack.Key(0)]
        public string FileName { get; set; }

        /// <summary>
        /// The arguments of the process.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string Arguments { get; set; }

        /// <summary>
        /// The working directory of the process.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// The username of the process.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(3)]
        public string Username { get; set; }

        /// <summary>
        /// The password of the process.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(4)]
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