﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product user price.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductUserPrice : IProductUserPriceApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product this user price is associated with.
        /// </summary>
        [Key(1)]
        public int ProductId { get; set; }

        /// <summary>
        /// The Id of the user group this user price is associated with.
        /// </summary>
        [Key(2)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// The price for this user price.
        /// </summary>
        [Key(3)]
        public decimal? Price { get; set; }

        #endregion
    }
}