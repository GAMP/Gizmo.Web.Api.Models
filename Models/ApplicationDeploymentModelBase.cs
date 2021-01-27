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
        /// Gets or sets name.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets registry string.
        /// </summary>
        [DataMember]
        [StringLength(16777215)]
        public string RegistryString { get; set; }

        /// <summary>
        /// Gets or sets source.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets destination.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Destination { get; set; }

        ///// <summary>
        ///// Gets or sets comparison level.
        ///// </summary>
        //[DataMember]
        //public FileInfoLevel ComparisonLevel { get; set; }

        ///// <summary>
        ///// Gets or sets options.
        ///// </summary>
        //[DataMember]
        //[Required]
        //public DeployOptionType Options { get; set; }

        #endregion
    }
}
