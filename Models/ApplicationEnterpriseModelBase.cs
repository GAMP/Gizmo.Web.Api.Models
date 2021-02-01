using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application enterprise.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationEnterpriseModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the enterprise.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        #endregion
    }
}