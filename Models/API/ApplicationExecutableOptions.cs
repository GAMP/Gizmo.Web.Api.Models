using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable options.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationExecutableOptions
    {
        /// <summary>
        /// Auto launch.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public bool AutoLaunch { get; set; }

        /// <summary>
        /// Monitor children.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public bool MonitorChildren { get; set; }

        /// <summary>
        /// Multi run.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public bool MultiRun { get; set; }

        /// <summary>
        /// Kill children.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public bool KillChildren { get; set; }

        /// <summary>
        /// Quick launch.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public bool QuickLaunch { get; set; }

        /// <summary>
        /// Shell execute.
        /// </summary>
        [DataMember]
        [MessagePack.Key(5)]
        public bool ShellExecute { get; set; }

        /// <summary>
        /// Ignore concurrent execution limit.
        /// </summary>
        [DataMember]
        [MessagePack.Key(6)]
        public bool IgnoreConcurrentExecutionLimit { get; set; }
    }
}