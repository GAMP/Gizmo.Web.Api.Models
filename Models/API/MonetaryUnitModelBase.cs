﻿using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Monetary unit.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class MonetaryUnitModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the monetary unit.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The value of the monetary unit.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(1)]
        public decimal Value { get; set; }

        /// <summary>
        /// The display order of the monetary unit.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the monetary unit is deleted.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public bool IsDeleted { get; set; }

        #endregion
    }
}