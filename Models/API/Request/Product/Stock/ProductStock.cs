using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.Stock
{
    /// <summary>
    /// Product stock.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductStock : IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The amount of stock.
        /// </summary>
        [Key(1)]
        public decimal? OnHand { get; set; }

        #endregion
    }
}