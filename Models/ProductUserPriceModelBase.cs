using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product user price.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductUserPriceModelBase : ProductUserPriceBase
    {
        #region PROPERTIES

        /// <summary>
        /// The price in points for this user price.
        /// </summary>
        [DataMember]
        public int? PointsPrice { get; set; }

        /// <summary>
        /// The purchase options for this user price.
        /// </summary>
        [DataMember]
        [Required]
        public PurchaseOptionType PurchaseOptions { get; set; }

        /// <summary>
        /// Whether this user prices is enabled.
        /// </summary>
        [DataMember]
        public bool IsEnabled { get; set; }

        #endregion
    }
}