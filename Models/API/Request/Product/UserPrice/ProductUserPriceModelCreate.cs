using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.UserPrice
{
    /// <summary>
    /// Product user price.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductUserPriceModelCreate : IProductUserPriceApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user group this user price is associated with.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// The price for this user price.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal? Price { get; set; }

        #endregion
    }
}