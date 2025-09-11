using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount target group requirement.
    /// </summary>
    public enum TargetGroupRequirement
    {
        /// <summary>
        /// All.
        /// </summary>
        [Name("All", "TARGET_GROUP_REQUIREMENT_ALL")]
        All = 0,

        /// <summary>
        /// Any.
        /// </summary>
        [Name("Any", "TARGET_GROUP_REQUIREMENT_ANY")]
        Any = 1,
    }
}
