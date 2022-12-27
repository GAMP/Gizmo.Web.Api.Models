using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Executable.Deployment
{
    /// <summary>
    /// Application executable deployment.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationExecutableDeploymentModelCreate : IApplicationExecutableDeploymentApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the deployment associated with this application executable.
        /// </summary>
        [MessagePack.Key(0)]
        public int DeploymentId { get; set; }

        /// <summary>
        /// The order in which the deployment is used.
        /// </summary>
        [MessagePack.Key(1)]
        public int UseOrder { get; set; }

        #endregion
    }
}
