using MessagePack;
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
    [MessagePackObject]
    public class ProductUserPriceModelBase : ProductUserPriceBase
    {
        #region PROPERTIES

        /// <summary>
        /// The price in points for this user price.
        /// </summary>
        [DataMember]
        [MessagePack.Key(100)]
        public int? PointsPrice { get; set; }

        /// <summary>
        /// The purchase options for this user price.
        /// </summary>
        [DataMember]
        [Required]
        [EnumValueValidation]
        [MessagePack.Key(101)]
        public PurchaseOptionType PurchaseOptions { get; set; }

        /// <summary>
        /// Whether the user prices is enabled.
        /// </summary>
        [DataMember]
        [MessagePack.Key(102)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}