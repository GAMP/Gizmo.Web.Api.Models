namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Branch.
    /// </summary>
    public interface IBranchModel : IWebApiModel
    {
        /// <summary>
        /// Branch name.
        /// </summary>
        public string Name { get; }
    }
}
