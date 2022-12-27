﻿using Gizmo.Web.Api.Models.Models.API.Request.Application.Deployment;

namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Application deployment.
    /// </summary>
    public interface IApplicationDeploymentApiModel
    {
        ///// <summary>
        /// The deployment options of the deployment.
        ///// </summary>
        ApplicationDeploymentComparisonMode ComparisonMode { get; set; }

        /// <summary>
        /// The deployment options of the deployment.
        /// </summary>
        ApplicationDeploymentOptions DeploymentOptions { get; set; }

        /// <summary>
        /// The destination of the deployment.
        /// </summary>
        string Destination { get; set; }

        /// <summary>
        /// The name of the deployment.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The registry string of the deployment.
        /// </summary>
        string RegistryString { get; set; }

        /// <summary>
        /// The source of the deployment.
        /// </summary>
        string Source { get; set; }
    }
}