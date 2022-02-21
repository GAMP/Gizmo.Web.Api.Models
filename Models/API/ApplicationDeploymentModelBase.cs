using MessagePack;
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
    [MessagePackObject]
    public class ApplicationDeploymentModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the deployment.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The registry string of the deployment.
        /// </summary>
        [DataMember]
        [StringLength(16777215)]
        [MessagePack.Key(1)]
        public string RegistryString { get; set; }

        /// <summary>
        /// The source of the deployment.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string Source { get; set; }

        /// <summary>
        /// The destination of the deployment.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        [MessagePack.Key(3)]
        public string Destination { get; set; }

        ///// <summary>
        /// The deployment options of the deployment.
        ///// </summary>
        //[DataMember]
        //public FileInfoLevel ComparisonLevel { get; set; }
        [DataMember]
        [EnumValue]
        [MessagePack.Key(4)]
        public ApplicationDeploymentComparisonMode ComparisonMode { get; set; }

        /// <summary>
        /// The deployment options of the deployment.
        /// </summary>
        [DataMember]
        [MessagePack.Key(5)]
        public ApplicationDeploymentOptions DeploymentOptions { get; set; }

        #endregion
    }
}