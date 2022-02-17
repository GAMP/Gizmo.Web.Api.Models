namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application deployment options.
    /// </summary>
    public class ApplicationDeploymentOptions
    {
        /// <summary>
        /// Marks deployment as ignored from cleanup procedures.
        /// </summary>
        public bool IgnoreCleanup { get; set; }

        /// <summary>
        /// Indicates that deployment should be done only on repair procedures.
        /// </summary>
        public bool RepairOnly { get; set; }

        /// <summary>
        /// Indicates direct access to the deployment source.
        /// </summary>
        public bool DirectAccess { get; set; }

        /// <summary>
        /// Indicates mirroring of destination directory.
        /// </summary>
        public bool Mirror { get; set; }

        /// <summary>
        /// Indicates inclusion of sub directories.
        /// </summary>
        public bool IncludeSubDirectories { get; set; }
    }
}