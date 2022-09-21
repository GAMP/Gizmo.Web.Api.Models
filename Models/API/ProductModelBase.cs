using MessagePack;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ProductModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the product group this product belongs to.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public int ProductGroupId { get; set; }

        /// <summary>
        /// The name of the product.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        [MessagePack.Key(1)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the product.
        /// </summary>
        [DataMember]
        [StringLength(65535)]
        [MessagePack.Key(2)]
        public string Description { get; set; }

        /// <summary>
        /// The price of the product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public decimal Price { get; set; }

        /// <summary>
        /// The cost of the product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public decimal? Cost { get; set; }

        /// <summary>
        /// Disallow order from client.
        /// </summary>
        [DataMember]
        [MessagePack.Key(5)]
        public bool DisallowClientOrder { get; set; }

        /// <summary>
        /// Disallow ability of order for non users.
        /// </summary>
        [DataMember]
        [MessagePack.Key(6)]
        public bool RestrictGuestSale { get; set; }

        /// <summary>
        /// Restricts product sale.
        /// </summary>
        [DataMember]
        [MessagePack.Key(7)]
        public bool RestrictSale { get; set; }

        /// <summary>
        /// The purchase options of the product.
        /// </summary>
        [DataMember]
        [Required]
        [EnumValueValidation]
        [MessagePack.Key(8)]
        public PurchaseOptionType PurchaseOptions { get; set; }

        /// <summary>
        /// The amount of points the user earns when purchasing this product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(9)]
        public int? Points { get; set; }

        /// <summary>
        /// The cost in points of the product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(10)]
        public int? PointsPrice { get; set; }

        /// <summary>
        /// The barcode of the product.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        [MessagePack.Key(11)]
        public string Barcode { get; set; }

        /// <summary>
        /// Enable stock.
        /// </summary>
        [DataMember]
        [MessagePack.Key(12)]
        public bool EnableStock { get; set; }

        /// <summary>
        /// Disallow out of stock sale.
        /// </summary>
        [DataMember]
        [MessagePack.Key(13)]
        public bool DisallowSaleIfOutOfStock { get; set; }

        /// <summary>
        /// Alert out of stock.
        /// </summary>
        [DataMember]
        [MessagePack.Key(14)]
        public bool StockAlert { get; set; }

        /// <summary>
        /// The stock quantity threshold to alert, if the stock alert is enabled.
        /// </summary>
        [DataMember]
        [MessagePack.Key(15)]
        public decimal StockAlertThreshold { get; set; }

        /// <summary>
        /// Enable stock keeping based on different product's stock.
        /// </summary>
        [DataMember]
        [MessagePack.Key(16)]
        public bool StockTargetDifferentProduct { get; set; }

        /// <summary>
        /// The Id of the target product, if the product stock targets a different product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(17)]
        public int? StockTargetProductId { get; set; }

        /// <summary>
        /// The ratio of the stock in relation to the stock of the target product, if the product stock targets a different product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(18)]
        public decimal StockProductAmount { get; set; }

        /// <summary>
        /// Whether the product is deleted.
        /// </summary>
        [DataMember]
        [MessagePack.Key(19)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// The product represents a service.
        /// </summary>
        [DataMember()]
        [MessagePack.Key(23)]
        public bool IsService { get; set; }

        /// <summary>
        /// The display order of the product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(20)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The time product object attached to this product if the product is a time product, otherwise it will be null.
        /// </summary>
        [DataMember]
        [MessagePack.Key(21)]
        public TimeProduct TimeProduct { get; set; }

        /// <summary>
        /// The bundle object attached to this product if the product is a bundle, otherwise it will be null.
        /// </summary>
        [DataMember]
        [MessagePack.Key(22)]
        public Bundle Bundle { get; set; }       

        #endregion
    }
}