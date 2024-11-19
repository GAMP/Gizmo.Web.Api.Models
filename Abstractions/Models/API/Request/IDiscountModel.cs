namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Discount model.
    /// </summary>
    public interface IDiscountModel
    {
        /// <summary>
        /// Name.
        /// </summary>
        string Name { get; init; }

        /// <summary>
        /// Description.
        /// </summary>
        string? Description { get; init; }
    }
}
