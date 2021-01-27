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
    public class ApplicationExecutableDeploymentModelCreate : ApplicationExecutableDeploymentModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        [Required]
        public int DeploymentId { get; set; }

        #endregion
    }
}
