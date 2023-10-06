namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Shift end count model.
    /// </summary>
    public interface IShiftEndCountModel
    {
        /// <summary>
        /// Actual.
        /// </summary>
        decimal Actual { get; init; }

        /// <summary>
        /// Payment method id.
        /// </summary>
        int PaymentMethodId { get; init; }
    }
}
