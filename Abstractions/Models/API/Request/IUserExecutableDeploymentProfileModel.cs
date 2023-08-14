namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User executable deployment profile model.
    /// </summary>
    public interface IUserExecutableDeploymentProfileModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets deployment profile id.
        /// </summary>
        int DeploymentProfileId { get; init; }
    }
}
