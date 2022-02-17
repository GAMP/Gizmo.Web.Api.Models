using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task junction.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApplicationTaskJunction
    {
        #region PROPERTIES

        /// <summary>
        /// The source directory of the junction.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string SourceDirectory { get; set; }

        /// <summary>
        /// The destination directory of the junction.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string DestinationDirectory { get; set; }

        /// <summary>
        /// Whether the junction deletes the destination.
        /// </summary>
        [DataMember]
        public bool DeleteDestination { get; set; }

        #endregion
    }
}