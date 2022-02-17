using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable options.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationExecutableOptions
    {
        /// <summary>
        /// Auto launch.
        /// </summary>
        [DataMember]
        public bool AutoLaunch { get; set; }

        /// <summary>
        /// Monitor children.
        /// </summary>
        [DataMember]
        public bool MonitorChildren { get; set; }

        /// <summary>
        /// Multi run.
        /// </summary>
        [DataMember]
        public bool MultiRun { get; set; }

        /// <summary>
        /// Kill children.
        /// </summary>
        [DataMember]
        public bool KillChildren { get; set; }

        /// <summary>
        /// Quick launch.
        /// </summary>
        [DataMember]
        public bool QuickLaunch { get; set; }

        /// <summary>
        /// Shell execute.
        /// </summary>
        [DataMember]
        public bool ShellExecute { get; set; }

        /// <summary>
        /// Ignore concurrent execution limit.
        /// </summary>
        [DataMember]
        public bool IgnoreConcurrentExecutionLimit { get; set; }
    }
}