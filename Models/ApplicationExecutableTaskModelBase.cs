using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable task.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationExecutableTaskModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        [Required]
        public int TaskId { get; set; }

        /// <summary>
        /// Pre launch/
        /// </summary>
        [DataMember]
        public bool PreLaunch { get; set; }

        /// <summary>
        /// Post deploy.
        /// </summary>
        [DataMember]
        public bool PreDeploy { get; set; }

        /// <summary>
        /// Post termination.
        /// </summary>
        [DataMember]
        public bool PostTermination { get; set; }

        /// <summary>
        /// Pre licenses management.
        /// </summary>
        [DataMember]
        public bool PreLicenseManagement { get; set; }

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public int UseOrder { get; set; }

        /// <summary>
        /// Whether the executable is enabled.
        /// </summary>
        [DataMember]
        public bool IsEnabled { get; set; }

        #endregion
    }
}