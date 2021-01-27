using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Gets
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApplicationTaskProcess
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets process file name.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets arguments.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Arguments { get; set; }

        /// <summary>
        /// Gets or sets working directory.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// Gets or sets user name.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets password.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string Password { get; set; }

        ///// <summary>
        ///// Gets or sets options.
        ///// </summary>
        //[DataMember]
        //TODO: A public TaskProcessOptionType ProcessOptions { get; set; }

        #endregion
    }
}