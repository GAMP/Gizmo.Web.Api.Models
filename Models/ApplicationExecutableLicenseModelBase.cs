using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable license.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationExecutableLicenseModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        [Required]
        public int LicenseId { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public int UseOrder { get; set; }

        #endregion
    }
}