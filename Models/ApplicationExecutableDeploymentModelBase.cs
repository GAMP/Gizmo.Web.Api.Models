using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable deployment.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationExecutableDeploymentModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        [Required]
        public int DeploymentId { get; set; }

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        [DataMember]
        public int UseOrder { get; set; }

        #endregion
    }
}
