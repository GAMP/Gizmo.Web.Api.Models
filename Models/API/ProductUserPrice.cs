﻿using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product user price.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ProductUserPrice : ProductUserPriceModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(200)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product this user price is associated with.
        /// </summary>
        [Required]
        [MessagePack.Key(201)]
        public int ProductId { get; set; }

        #endregion
    }
}