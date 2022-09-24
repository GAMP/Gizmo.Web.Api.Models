using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product tax.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductTaxModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Tax id.
        /// </summary>
        [Key(0)]
        public int TaxId { get; set; }

        /// <summary>
        /// Use order.
        /// </summary>
        [Key(1)]
        public int UseOrder { get; set; }

        /// <summary>
        /// Indicates if product tax is enabled.
        /// </summary>
        [Key(2)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}