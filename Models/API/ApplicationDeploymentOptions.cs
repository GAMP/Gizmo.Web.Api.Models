using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application deployment options.
    /// </summary>
    [MessagePackObject]
    public class ApplicationDeploymentOptions
    {
        /// <summary>
        /// Marks deployment as ignored from cleanup procedures.
        /// </summary>
        [MessagePack.Key(0)]
        public bool IgnoreCleanup { get; set; }

        /// <summary>
        /// Indicates that deployment should be done only on repair procedures.
        /// </summary>
        [MessagePack.Key(1)]
        public bool RepairOnly { get; set; }

        /// <summary>
        /// Indicates direct access to the deployment source.
        /// </summary>
        [MessagePack.Key(2)]
        public bool DirectAccess { get; set; }

        /// <summary>
        /// Indicates mirroring of destination directory.
        /// </summary>
        [MessagePack.Key(3)]
        public bool Mirror { get; set; }

        /// <summary>
        /// Indicates inclusion of sub directories.
        /// </summary>
        [MessagePack.Key(4)]
        public bool IncludeSubDirectories { get; set; }
    }
}