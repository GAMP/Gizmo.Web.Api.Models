﻿using MessagePack;
using System;
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
    public class ProductModelCreate : ProductModelBase, IUrlQueryParameters
    {
        /// <summary>
        /// The type of the product.
        /// </summary>
        [DataMember]
        [Required]
        [EnumValue]
        [MessagePack.Key(100)]
        public ProductType ProductType { get; set; }
    }
}