namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Point transaction model base.
    /// </summary>
    public interface IPointTransactionApiModel
    {
        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        int UserId { get; set; }

        /// <summary>
        /// Gets or sets transaction type.
        /// </summary>
        PointsTransactionType Type { get; set; }

        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        int Amount { get; set; }
    }
}
