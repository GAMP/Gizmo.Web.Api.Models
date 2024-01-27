namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Branch based filter.
    /// </summary>
    public interface IBranchBasedModelFilter
    {
        /// <summary>
        /// Filtered branch id.
        /// </summary>
        /// <remarks>
        /// Any filter that filters by branch must implement this interface.<br></br>
        /// The property must have a setter since it will be dynamically modified based on current authentication context.
        /// </remarks>
        public int? BranchId { get; set; }
    }
}
