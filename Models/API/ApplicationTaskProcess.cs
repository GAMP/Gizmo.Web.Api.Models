using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task process.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApplicationTaskProcess
    {
        #region PROPERTIES

        /// <summary>
        /// The file name of the process.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        /// <summary>
        /// The arguments of the process.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Arguments { get; set; }

        /// <summary>
        /// The working directory of the process.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// The username of the process.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string Username { get; set; }

        /// <summary>
        /// The password of the process.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string Password { get; set; }

        /// <summary>
        /// Whether the process is awaited until exit.
        /// </summary>
        [DataMember]
        public bool Wait { get; set; }

        /// <summary>
        /// Whether the process is invisible.
        /// </summary>
        [DataMember]
        public bool NoWindow { get; set; }

        #endregion
    }
}