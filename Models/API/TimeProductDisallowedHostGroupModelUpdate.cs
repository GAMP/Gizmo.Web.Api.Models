﻿using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time product disallowed host group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class TimeProductDisallowedHostGroupModelUpdate : TimeProductDisallowedHostGroupModelBase, IEntityBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the time product.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(101)]
        public int TimeProductId { get; set; }

        #endregion
    }
}