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
        /// The name of the application license.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets plugin type name.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Plugin { get; set; }

        /// <summary>
        /// Gets or sets plugin assembly.
        /// </summary>        
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Assembly { get; set; }

        /// <summary>
        /// Gets or sets settings.
        /// </summary>
        [DataMember]
        public byte[] Settings { get; set; }

        #endregion
    }
}