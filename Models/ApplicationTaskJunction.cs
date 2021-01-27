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
    public class ApplicationTaskJunction
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets junction source directory.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string SourceDirectory { get; set; }

        /// <summary>
        /// Gets or sets junction destination directory.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string DestinationDirectory { get; set; }

        ///// <summary>
        ///// Gets or sets options.
        ///// </summary>
        //[DataMember]
        //TODO: A public TaskJunctionOptionType Options { get; set; }

        #endregion
    }
}