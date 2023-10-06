namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Active shift.
    /// </summary>
    public interface IActiveShiftModel : IWebApiModel
    {
        /// <summary>
        /// Branch id.
        /// </summary>
        int BranchId { get; init; }

        /// <summary>
        /// Shift id.
        /// </summary>
        int Id { get; init; }

        /// <summary>
        /// Register id.
        /// </summary>
        int RegisterId { get; init; }
    }
}
