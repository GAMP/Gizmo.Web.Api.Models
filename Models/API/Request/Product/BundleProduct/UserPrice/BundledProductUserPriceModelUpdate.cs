﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.BundleProduct.UserPrice
{
    /// <summary>
    /// Bundled product user price.
    /// </summary>
    [MessagePackObject]
    public sealed class BundledProductUserPriceModelUpdate : IProductUserPriceApiModel, IApiModelIdentifier, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the bundled product this user price is associated with.
        /// </summary>
        [MessagePack.Key(1)]
        public int BundledProductId { get; set; }

        /// <summary>
        /// The Id of the user group this user price is associated with.
        /// </summary>
        [MessagePack.Key(2)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// The price for this user price.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal? Price { get; set; }

        #endregion
    }
}