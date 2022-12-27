﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Executable.Deployment
{
    /// <summary>
    /// Application executable deployment.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationExecutableDeployment : IApplicationExecutableDeploymentApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the application executable.
        /// </summary>
        [MessagePack.Key(0)]
        public int ApplicationExecutableId { get; set; }

        /// <summary>
        /// The Id of the deployment associated with this application executable.
        /// </summary>
        [Required]
        [MessagePack.Key(1)]
        public int DeploymentId { get; set; }

        /// <summary>
        /// The order in which the deployment is used.
        /// </summary>
        [MessagePack.Key(2)]
        public int UseOrder { get; set; }

        #endregion
    }
}
