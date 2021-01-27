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
    public class ApplicationExecutableDeployment : ApplicationExecutableDeploymentModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the executable this deployment is associated with.
        /// </summary>
        [DataMember]
        public int ApplicationExecutableId { get; set; }

        #endregion
    }
}
