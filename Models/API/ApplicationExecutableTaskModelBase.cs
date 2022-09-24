using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable task.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutableTaskModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the task associated with this application executable.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int TaskId { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Deploy stage.
        /// </summary>
        [MessagePack.Key(1)]
        public bool PreDeploy { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Licenses Management stage.
        /// </summary>
        [MessagePack.Key(2)]
        public bool PreLicenseManagement { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Launch stage.
        /// </summary>
        [MessagePack.Key(3)]
        public bool PreLaunch { get; set; }

        /// <summary>
        /// Whether the task runs at Post Termination stage.
        /// </summary>
        [MessagePack.Key(4)]
        public bool PostTermination { get; set; }

        /// <summary>
        /// The order in which the task is used.
        /// </summary>
        [MessagePack.Key(5)]
        public int UseOrder { get; set; }

        /// <summary>
        /// Whether the executable is enabled.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}