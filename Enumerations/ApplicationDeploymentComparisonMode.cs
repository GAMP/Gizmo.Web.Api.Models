namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application deployment comparison mode.
    /// </summary>
    public enum ApplicationDeploymentComparisonMode : int
    {
        /// <summary>
        /// Fast.
        /// </summary>
        Fast = 0,

        /// <summary>
        /// Standard.
        /// </summary>
        Standard = 1,

        /// <summary>
        /// No attributes.
        /// </summary>
        StandardNoAttributes = 2,
        
        /// <summary>
        /// Through.
        /// </summary>
        Thorough = 3
    }
}
