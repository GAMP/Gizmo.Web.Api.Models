using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application group application.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationGroupApplicationModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        [Required]
        public int ApplicationId { get; set; }

        #endregion
    }
}
