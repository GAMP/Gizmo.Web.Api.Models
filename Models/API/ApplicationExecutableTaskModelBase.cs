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
        /// The Id of the task associated with this application executable.
        /// </summary>
        [DataMember]
        [Required]
        public int TaskId { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Deploy stage.
        /// </summary>
        [DataMember]
        public bool PreDeploy { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Licenses Management stage.
        /// </summary>
        [DataMember]
        public bool PreLicenseManagement { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Launch stage.
        /// </summary>
        [DataMember]
        public bool PreLaunch { get; set; }

        /// <summary>
        /// Whether the task runs at Post Termination stage.
        /// </summary>
        [DataMember]
        public bool PostTermination { get; set; }

        /// <summary>
        /// The order in which the task is used.
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