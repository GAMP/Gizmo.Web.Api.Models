namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Identifies how a server instance is being hosted.
    /// </summary>
    public enum HostingMode
    {
        /// <summary>
        /// Installed and run directly on the host operating system.
        /// </summary>
        SelfHosted = 0,

        /// <summary>
        /// Running inside a container managed by the customer.
        /// </summary>
        SelfHostedContainer = 1,

        /// <summary>
        /// Running inside a container on Gizmo-managed cloud infrastructure.
        /// </summary>
        ManagedContainer = 2,
    }
}
