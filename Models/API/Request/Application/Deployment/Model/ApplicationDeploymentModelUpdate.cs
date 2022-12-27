using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Deployment.Model
{
    /// <summary>
    /// Application deployment.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationDeploymentModelUpdate : IApplicationDeploymentApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The name of the deployment.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// The registry string of the deployment.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(16777215)]
        public string RegistryString { get; set; }

        /// <summary>
        /// The source of the deployment.
        /// </summary>
        [MessagePack.Key(3)]
        [Required]
        [StringLength(255)]
        public string Source { get; set; }

        /// <summary>
        /// The destination of the deployment.
        /// </summary>
        [MessagePack.Key(4)]
        [Required]
        [StringLength(255)]
        public string Destination { get; set; }

        ///// <summary>
        /// The deployment options of the deployment.
        ///// </summary>
        [MessagePack.Key(5)]
        [EnumValueValidation]
        public ApplicationDeploymentComparisonMode ComparisonMode { get; set; }

        /// <summary>
        /// The deployment options of the deployment.
        /// </summary>
        [MessagePack.Key(6)]
        public ApplicationDeploymentOptions DeploymentOptions { get; set; }
        #endregion
    }
}
