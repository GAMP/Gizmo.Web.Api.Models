﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable task.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationExecutableTask : IApplicationExecutableTaskApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the application executable.
        /// </summary>
        [MessagePack.Key(0)]
        public int ApplicationExecutableId { get; set; }

        /// <summary>
        /// The Id of the task associated with this application executable.
        /// </summary>
        [MessagePack.Key(1)]
        public int TaskId { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Deploy stage.
        /// </summary>
        [MessagePack.Key(2)]
        public bool PreDeploy { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Licenses Management stage.
        /// </summary>
        [MessagePack.Key(3)]
        public bool PreLicenseManagement { get; set; }

        /// <summary>
        /// Whether the task runs at Pre Launch stage.
        /// </summary>
        [MessagePack.Key(4)]
        public bool PreLaunch { get; set; }

        /// <summary>
        /// Whether the task runs at Post Termination stage.
        /// </summary>
        [MessagePack.Key(5)]
        public bool PostTermination { get; set; }

        /// <summary>
        /// The order in which the task is used.
        /// </summary>
        [MessagePack.Key(6)]
        public int UseOrder { get; set; }

        /// <summary>
        /// Whether the executable is enabled.
        /// </summary>
        [MessagePack.Key(7)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}