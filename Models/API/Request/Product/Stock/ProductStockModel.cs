using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product stock.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ProductStockModel : IModelIntIdentifier, IWebApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The amount of stock.
        /// </summary>
        /// <remarks>
        /// Null value indicates that there are no stock transactions made for the product effectively meaning that the current stock level is unknown.
        /// </remarks>
        [Key(1)]
        public decimal? OnHand { get; set; }

        /// <summary>
        /// Indicates that product have reached alert level.
        /// </summary>
        [Key(2)]
        public bool AlertLevelReached { get; init; }

        #endregion
    }
}
