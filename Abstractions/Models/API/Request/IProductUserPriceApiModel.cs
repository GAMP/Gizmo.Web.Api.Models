namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Product user price base.
    /// </summary>
    public interface IProductUserPriceApiModel
    {
        /// <summary>
        /// The price for this user price.
        /// </summary>
        decimal? Price { get; set; }

        /// <summary>
        /// The Id of the user group this user price is associated with.
        /// </summary>
        int UserGroupId { get; set; }
    }
}