using MessagePack;
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
    [MessagePackObject]
    public class ApplicationExecutableDeploymentModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the deployment associated with this application executable.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public int DeploymentId { get; set; }

        /// <summary>
        /// The order in which the deployment is used.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public int UseOrder { get; set; }

        #endregion
    }
}
