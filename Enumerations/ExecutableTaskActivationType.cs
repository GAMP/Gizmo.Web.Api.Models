namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Executable task activation types.
    /// </summary>
    public enum ExecutableTaskActivationType
    {
        /// <summary>
        /// Pre launch.
        /// </summary>
        PreLaunch = 16,

        /// <summary>
        /// Post deploy.
        /// </summary>
        PreDeploy = 32,

        /// <summary>
        /// Post termination.
        /// </summary>
        PostTermination = 64,

        /// <summary>
        /// Pre licenses management.
        /// </summary>
        PreLicenseManagement = 128
    }
}
