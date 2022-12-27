using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.Tax
{
    /// <summary>
    /// Product tax.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductTax : ProductTaxModelBase, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product this tax belongs to.
        /// </summary>
        [Key(100)]
        public int ProductId { get; set; }

        #endregion
    }
}