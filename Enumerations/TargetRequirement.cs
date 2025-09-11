using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Source list requirements.
    /// </summary>
    public enum TargetRequirement
    {
        /// <summary>
        /// All items in list.
        /// </summary>
        /// <remarks>
        /// This rule requires that customer purchase all target products.
        /// </remarks>
        [Name("All", "TARGET_REQUIREMENT_ALL")]
        All = 0,

        /// <summary>
        /// Any of items in list.
        /// </summary>
        /// <remarks>
        /// This can also be considered as one of.
        /// This rule basically requires that customer purchase at least one of the target products.
        /// </remarks>
        [Name("Any", "TARGET_REQUIREMENT_ANY")]
        Any = 1,

        /// <summary>
        /// Specific amount of items in the list.
        /// </summary>
        /// <remarks>
        /// This rule requires that customer purchase at least the amount of target products.
        /// </remarks>
        [Name("Count", "TARGET_REQUIREMENT_COUNT")]
        Count = 2,

        /// <summary>
        /// Mnium amount spent on target list.
        /// </summary>
        /// <remarks>
        /// This rule requires that customer spend at least amount on target products.
        /// </remarks>
        [Name("Amount", "TARGET_REQUIREMENT_AMOUNT")]
        Amount = 3,
    }
}
