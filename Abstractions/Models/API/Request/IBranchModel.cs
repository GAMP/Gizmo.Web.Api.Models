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

        /// <summary>
        /// Branch time zone identifier.
        /// </summary>
        public string? TimeZone { get; }

        /// <summary>
        /// Indicates that branch is default.
        /// </summary>
        public bool IsDefault { get; }

        /// <summary>
        /// Indicates that branch is enabled.
        /// </summary>
        public bool IsEnabled { get; }

        /// <summary>
        /// Indicates that branch is deleted.
        /// </summary>
        public bool IsDeleted { get; }
    }
}
