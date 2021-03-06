﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundled product.
    /// </summary>
    [Serializable]
    [DataContract]
    public class BundledProductModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the product.
        /// </summary>
        [DataMember]
        [Required]
        public int ProductId { get; set; }

        /// <summary>
        /// The quantity of the product within the bundle.
        /// </summary>
        [DataMember]
        [Required]
        [Range(1, int.MaxValue)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The unit price of the product within the bundle.
        /// </summary>
        [DataMember]
        [Required]
        public decimal UnitPrice { get; set; }

        #endregion
    }
}