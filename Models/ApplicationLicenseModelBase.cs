using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application license.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationLicenseModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the license.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// The plugin type name of the license.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Plugin { get; set; }

        /// <summary>
        /// The plugin assembly of the license.
        /// </summary>        
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Assembly { get; set; }

        /// <summary>
        /// The settings of the license.
        /// </summary>
        [DataMember]
        public byte[] Settings { get; set; }

        #endregion
    }
}