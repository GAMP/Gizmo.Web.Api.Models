using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User product model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserProductModel : IUserProductModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The type of the product.
        /// </summary>
        [Key(1)]
        public ProductType ProductType { get; set; }

        /// <summary>
        /// The Id of the product group this product belongs to.
        /// </summary>
        [Key(2)]
        public int ProductGroupId { get; set; }

        /// <summary>
        /// The name of the product group this product belongs to.
        /// </summary>
        [Key(3)]
        public string ProductGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the product.
        /// </summary>
        [Key(4)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The description of the product.
        /// </summary>
        [Key(5)]
        public string? Description { get; set; }

        /// <summary>
        /// The price of the product.
        /// </summary>
        [Key(6)]
        public decimal Price { get; set; }

        /// <summary>
        /// The cost in points of the product.
        /// </summary>
        [Key(7)]
        public int? PointsPrice { get; set; }

        /// <summary>
        /// The amount of points the user earns when purchasing this product.
        /// </summary>
        [Key(8)]
        public int? PointsAward { get; set; }

        /// <summary>
        /// The purchase options of the product.
        /// </summary>
        [Key(9)]
        public PurchaseOptionType PurchaseOptions { get; set; }

        /// <summary>
        /// The time product object attached to this product if the product is a time product, otherwise it will be null.
        /// </summary>
        [Key(10)]
        public UserProductTimeModel? TimeProduct { get; set; }

        /// <summary>
        /// The bundle object attached to this product if the product is a bundle, otherwise it will be null.
        /// </summary>
        [Key(11)]
        public UserProductBundleModel? Bundle { get; set; }

        #endregion
    }
}
