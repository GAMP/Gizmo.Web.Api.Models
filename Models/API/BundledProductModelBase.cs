﻿using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundled product.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class BundledProductModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the product.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int ProductId { get; set; }

        /// <summary>
        /// The quantity of the product within the bundle.
        /// </summary>
        [Required]
        [Range(1, int.MaxValue)]
        [MessagePack.Key(1)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The unit price of the product within the bundle.
        /// </summary>
        [Required]
        [MessagePack.Key(2)]
        public decimal UnitPrice { get; set; }

        #endregion
    }
}