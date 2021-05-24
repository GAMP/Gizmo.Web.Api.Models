using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application deployment.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationDeploymentModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the deployment.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// The registry string of the deployment.
        /// </summary>
        [DataMember]
        [StringLength(16777215)]
        public string RegistryString { get; set; }

        /// <summary>
        /// The source of the deployment.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Source { get; set; }

        /// <summary>
        /// The destination of the deployment.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Destination { get; set; }

        ///// <summary>
        /// The deployment options of the deployment.
        ///// </summary>
        //[DataMember]
        //public FileInfoLevel ComparisonLevel { get; set; }
        [DataMember]
        [EnumValue]
        public ApplicationDeploymentComparisonMode ComparisonMode { get; set; }

        /// <summary>
        /// The deployment options of the deployment.
        /// </summary>
        [DataMember]
        public ApplicationDeploymentOptions DeploymentOptions { get; set; }

        #endregion
    }
}