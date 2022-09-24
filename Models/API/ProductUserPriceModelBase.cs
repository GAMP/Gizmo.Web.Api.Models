using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product user price.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductUserPriceModelBase : ProductUserPriceBase
    {
        #region PROPERTIES

        /// <summary>
        /// The price in points for this user price.
        /// </summary>
        [MessagePack.Key(100)]
        public int? PointsPrice { get; set; }

        /// <summary>
        /// The purchase options for this user price.
        /// </summary>
        [Required]
        [EnumValueValidation]
        [MessagePack.Key(101)]
        public PurchaseOptionType PurchaseOptions { get; set; }

        /// <summary>
        /// Whether the user prices is enabled.
        /// </summary>
        [MessagePack.Key(102)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}