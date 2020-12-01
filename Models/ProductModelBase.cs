﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductModelBase : IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The type of the product.
        /// </summary>
        [DataMember]
        public ProductType ProductType { get; set; }

        /// <summary>
        /// The Id of the product group this product belongs to.
        /// </summary>
        [DataMember]
        [Required]
        public int ProductGroup { get; set; }

        /// <summary>
        /// The name of the product.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the product.
        /// </summary>
        [DataMember]
        [StringLength(65535)]
        public string Description { get; set; }

        /// <summary>
        /// The price of the product.
        /// </summary>
        [DataMember]
        public decimal Price { get; set; }

        /// <summary>
        /// The cost of the product.
        /// </summary>
        [DataMember]
        public decimal? Cost { get; set; }

        /// <summary>
        /// Client order disallowed.
        /// </summary>
        [DataMember]
        public bool DisallowAllowOrder { get; set; }

        /// <summary>
        /// Disallow ability of order for non users.
        /// </summary>
        [DataMember]
        public bool RestrictNonCustomers { get; set; }
        /// <summary>
        /// Restricts product sale.
        /// </summary>
        [DataMember]
        public bool RestrictSale { get; set; }

        /// <summary>
        /// The purchase options of the product.
        /// </summary>
        [DataMember]
        public PurchaseOptionType PurchaseOptions { get; set; }

        /// <summary>
        /// The amount of points the user earns when purchasing this product.
        /// </summary>
        [DataMember]
        public int? Points { get; set; }

        /// <summary>
        /// The cost in points of the product.
        /// </summary>
        [DataMember]
        public int? PointsPrice { get; set; }

        /// <summary>
        /// The barcode of the product.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Barcode { get; set; }

        /// <summary>
        /// Enable stock.
        /// </summary>
        [DataMember]
        public bool EnableStock { get; set; }

        /// <summary>
        /// Disallow out of stock sale.
        /// </summary>
        [DataMember]
        public bool DisallowSaleIfOutOfStock { get; set; }

        /// <summary>
        /// Alert out of stock.
        /// </summary>
        [DataMember]
        public bool StockAlert { get; set; }

        /// <summary>
        /// Target different product.
        /// </summary>
        [DataMember]
        public bool TargetDifferentProduct { get; set; }

        /// <summary>
        /// The stock quantity threshold to alert, if the stock alert is enabled.
        /// </summary>
        [DataMember]
        public decimal StockAlertThreshold { get; set; }

        /// <summary>
        /// The Id of the target product, if the product stock targets a different product.
        /// </summary>
        [DataMember]
        public int? StockTargetProduct { get; set; }

        /// <summary>
        /// The ratio of the stock in relation to the stock of the target product, if the product stock targets a different product.
        /// </summary>
        [DataMember]
        public decimal StockProductAmount { get; set; }

        /// <summary>
        /// Whether the product is deleted.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// The display order of the product.
        /// </summary>
        [DataMember]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The GUID of the product.
        /// </summary>
        [DataMember]
        public Guid Guid { get; set; }

        #endregion

        public string ToQueryParameters()
        {
            return ParameterGenerator.Generate(this);
        }
    }
}