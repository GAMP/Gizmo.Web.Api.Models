using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.Tax
{
    /// <summary>
    /// Product tax.
    /// </summary>
    [MessagePackObject]
    public sealed class ProductTax : IProductTaxApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product this tax belongs to.
        /// </summary>
        [Key(1)]
        public int ProductId { get; set; }

        /// <summary>
        /// Tax id.
        /// </summary>
        [Key(2)]
        public int TaxId { get; set; }

        /// <summary>
        /// Use order.
        /// </summary>
        [Key(3)]
        public int UseOrder { get; set; }

        /// <summary>
        /// Indicates if product tax is enabled.
        /// </summary>
        [Key(4)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}