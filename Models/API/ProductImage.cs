﻿using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product image.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductImage : ProductImageModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product this image belongs to.
        /// </summary>
        [Key(101)]
        public int ProductId { get; set; }

        #endregion
    }
}